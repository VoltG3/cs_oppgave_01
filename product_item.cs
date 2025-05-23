namespace cs_oppgave_01;

public class ProductItem 
{
    // Fields
    public string? Name { get; set; }
    public List<int>? Quantities { get; set; }
    public float Price { get; set; }
    public int InitialStockQuantity => Quantities[0];
    public int RemainingStockQuantity => Quantities[5];
    public int PriceProtectionRange => Price > 8000 ? 1 : Price > 4000 ? 2 : 3;
    public float DiscountPrice => CalcDiscount(Price, PriceProtectionRange, InitialStockQuantity, RemainingStockQuantity);
    
    // Constructor
    public ProductItem(string name, List<int> quantities, float price)
    {
        Name = name;
        Quantities = quantities;
        Price = price;
    }
    
    // Methods === Functions 
    public float CalcDiscount(float price, int priceProtectionRange, int initialStockQuantity, int remainingStockQuantity)
    {
        // Procentuals atlikums
        float  remainingPrecent = (remainingStockQuantity * 100f) / initialStockQuantity;
        
        float discountRateLessLeft = priceProtectionRange switch
        {
            1 => 0.33f,
            2 => 0.66f,
            3 => 0.99f,
            _ => 0.00f,
        };

        float discountRateStack = priceProtectionRange switch
        {
            1 => 0.33f,
            2 => 0.66f,
            3 => 0.99f,
            _ => 0.00f,
        };
        
        // ja preces palika vairak neka 50%
       if (remainingPrecent > 50f)
       {
           return price - (price * discountRateStack);
       }

       // ja perces palika mazak neka 10%
       if (remainingPrecent < 10f)
       {
           // product count :: if 10 or less than 10 left
           if (remainingStockQuantity <= 10)
           {
               return price - (price * discountRateLessLeft);
           }
           
       }
       
       return price;
    }
}
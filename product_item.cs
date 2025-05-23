namespace cs_oppgave_01;

public class ProductItem : IProductItem
{
    // Fields
    public string Name { get; set; }
    public List<int> Quantities { get; set; }
    public float Price { get; set; }
    public int InitialStockQuantity => Quantities![0];
    public int RemainingStockQuantity => Quantities![5];
    public int PriceProtectionRange => Price > 8000 ? 1 : Price > 4000 ? 2 : 3;
    public float RemainingStockQuantityPrecent => (RemainingStockQuantity * 100f) / InitialStockQuantity;
    public bool RemainingStockQuantityIsLow => RemainingStockQuantity <= 10;
    public float DiscountPrice => 
        CalcDiscount(
            Price, 
            PriceProtectionRange, 
            RemainingStockQuantityPrecent,
            RemainingStockQuantityIsLow
        );
    
    // Constructor
    public ProductItem(string name, List<int> quantities, float price)
    {
        Name = name;
        Quantities = quantities;
        Price = price;
    }
    
    // Methods === Functions 
    public float CalcDiscount(
        float price, int priceProtectionRange, 
        float remainingStockQuantityPrecent,
        bool remainingStockQuantityIsLow)
    {
        
        var discountRateLessLeft = priceProtectionRange switch
        {
            1 => 0.33f,
            2 => 0.66f,
            3 => 0.99f,
            _ => 0.00f,
        };

        var discountRateStack = priceProtectionRange switch
        {
            1 => 0.10f,
            2 => 0.15f,
            3 => 0.40f,
            _ => 0.00f,
        };
        
        // product count :: if 10 or less than 10 left
        if (remainingStockQuantityIsLow)
        {
            return price - price * discountRateLessLeft;
        }
        
        // if remainingStockQuantityPrecent is more than 50%
        if (remainingStockQuantityPrecent > 50f)
        {
            return price - price * discountRateStack;
        }
       
        return price;
    }
}
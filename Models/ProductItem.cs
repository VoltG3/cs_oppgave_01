namespace cs_oppgave_01;

public class ProductItem : IProductItem
{
    // Fields
    public string Name { get; set; }
    public List<int> Quantities { get; set; }
    public float Price { get; set; }
    public int DiscountRange => Price > 8000 ? 1 : Price > 4000 ? 2 : 3;
    public float RemainingStockPrecentage => (Quantities[6] * 100f) / Quantities[0];
    public bool IsRemainingStockLow => Quantities[6] <= 10;
    public float PriceWithDiscount => 
        CalcDiscount(
            Price, 
            DiscountRange, 
            RemainingStockPrecentage,
            IsRemainingStockLow
        );
    
    
    // Constructor
    public ProductItem(string name, List<int> quantities, float price)
    {
        Name = name;
        Quantities = quantities;
        Price = price;
    }

    public List<float> GetAllRemainingStockPrecentage()
    {
        var precentage = new List<float>();
        
        for (int i = 0; i < Quantities.Count; i++)
        {
            precentage.Add(Quantities[i] * 100f / Quantities[0]);
        }
        return precentage;
    }
    
    // Methods === Functions 
    public float CalcDiscount(
        float price, 
        int discountRange, 
        float remainingStockPrecentage,
        bool isRemainingStockLow)
    {
        
        var discountRateLessLeft = discountRange switch
        {
            1 => 0.33f,
            2 => 0.66f,
            3 => 0.99f,
            _ => 0.00f,
        };

        var discountRateStack = discountRange switch
        {
            1 => 0.10f,
            2 => 0.15f,
            3 => 0.40f,
            _ => 0.00f,
        };
        
        // product count :: if 10 or less than 10 left
        if (isRemainingStockLow)
        {
            return price - price * discountRateLessLeft;
        }
        
        // if the remainingStockPrecentage is more than 50%
        if (remainingStockPrecentage > 50f)
        {
            return price - price * discountRateStack;
        }
       
        return price;
    }
}
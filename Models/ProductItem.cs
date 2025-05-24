namespace cs_oppgave_01;

public class ProductItem : IProductItem
{
    // Fields
    public string Name { get; set; }
    public float Price { get; set; }
    public List<int> FlowStock { get; set; }
    public List<float> MonthlyFlowStockPct => CalcMonthlyFlow();
    public List<string> MonthlyFlag => CalcMonthlyFlag();
    public string FinalFlag => CalcFinalFlag();
    public float FinalStockPct => (FlowStock[6] * 100f) / FlowStock[0];
    public bool IsLowStock => FlowStock[6] <= 10;
    public int DiscountRange => Price > 8000 ? 1 : Price > 4000 ? 2 : 3;
    public float DiscountPrice => 
        CalcDiscount(
            Price, 
            DiscountRange, 
            FinalStockPct,
            IsLowStock
        );
    
    // Constructor
    public ProductItem(string name, List<int> flowStock, float price)
    {
        Name = name;
        FlowStock = flowStock;
        Price = price;
    }

    // Methods === Functions 
    public List<float> CalcMonthlyFlow()
    {
        var pct = new List<float>();
        
        for (int i = 0; i < FlowStock.Count; i++)
        {
            pct.Add(FlowStock[i] * 100f / FlowStock[0]);
        }
        return pct;
    }

    public List<string> CalcMonthlyFlag()
    {
        var flag = new List<string>();
        flag.Add("H");
    
        for (int i = 1; i < FlowStock.Count; i++)
        {
            if (FlowStock[i] == 0)
            {
                flag.Add("flow_empty");
            }
            else if (FlowStock[i] <= 10)
            {
                flag.Add("flow_quick");
            }
            else if (FlowStock[i] == FlowStock[i - 1])
            {
                flag.Add("flow_stack");
            }
            else if (FlowStock[i] < FlowStock[i - 1] * 0.9f)
            {
                flag.Add("flow_normal");
            }
            else if (FlowStock[i] > FlowStock[i - 1] * 0.9f)
            {
                flag.Add("flow_slow");
            }
            else if (FlowStock[i] == 0)
            {
                flag.Add("flow_empty");
            }
            else
            {
                flag.Add("UNKNOWN");
            }
            
        }
        return flag;
    }
    
    public string CalcFinalFlag()
    {
        string flag = "";
        for (int i = 1; i < FlowStock.Count; i++)
        {
            if (FlowStock[6] == 0)
            {
                flag = "flow_empty";
            }
            else if (FlowStock[6] <= 10)
            {
                flag = "flow_quick";
            }
            else if (FlowStock[6] == FlowStock[0])
            {
                flag = "flow_stack";
            }
            else if (FlowStock[6] < FlowStock[0] * 0.60f)
            {
                flag = "flow_normal";
            }
            else if (FlowStock[6] > FlowStock[0] * 0.49f)
            {
                //flag ="flow_slow";
                flag ="flow_stack";
            }
            else if (FlowStock[6] == 0)
            {
                flag = "flow_empty";
            }
            else
            {
                flag = "UNKNOWN";
            }
            
        }
        return flag;
    }
    
    public float CalcDiscount(
        float price, 
        int discountRange, 
        float finalStockPct,
        bool isLowStock)
    {
        
        var discountRateLowStock = discountRange switch
        {
            1 => 0.33f,
            2 => 0.66f,
            3 => 0.99f,
            _ => 0.00f,
        };

        var discountRateStackStock = discountRange switch
        {
            1 => 0.10f,
            2 => 0.15f,
            3 => 0.40f,
            _ => 0.00f,
        };
        
        // product count :: if 10 or less than 10 left
        if (isLowStock)
            return price - price * discountRateLowStock;
        
        // if the finalStockPct is more than 50%
        if (finalStockPct > 50f)
            return price - price * discountRateStackStock;
        
        return price;
    }
    
    // Destructor
    ~ProductItem()
    {
        Name = null;
        FlowStock = null;
    }
}
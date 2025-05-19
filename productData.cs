namespace cs_oppgave_01;

public class ProductData
{
    // Fields
    public List<string>? productName;
    public List<double>? productPrice;
    public List<int>? productQuantity;
    
    // Methods
    public void AddProduct(string name, double price, int quantity)
    {
        productName.Add(name);
        productPrice.Add(price);
        productQuantity.Add(quantity);
    }
    
    // Constructor
    public ProductData()
    {
        productName = new List<string>();
        productPrice = new List<double>();
        productQuantity = new List<int>();
    }
    
    // Functions
    private string ExtractName(string name)
    {
        switch (name)
        {
            case "HDD":
                return "Hard Disk Driver";
            case "SSD":
                return "Solid State Drive";
            case "RAM":
                return "Random Access Memory";
            case "CPU":
                return "Central Processing Unit";
            default:
                return name;
        }
    }
    public void PrintProductData()
    {
        Console.WriteLine("Product data:");
        for (int i = 0; i < productName.Count; i++)
        {
            Console.WriteLine(
                $"{ ExtractName(productName[i]) }" + 
                $"{ productPrice[i] }" + 
                $"{ productQuantity[i] }" +
                $"");
        }
    }
    
    // Destructor
    ~ProductData ()
    {
        productName.Clear();
        productPrice.Clear();
        productQuantity.Clear();
    }
}
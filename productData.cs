namespace cs_oppgave_01;

public class ProductData
{
    // Fields
    public List<string>? productName;
    public List<int>? productQuantity;
    public List<double>? productPrice;
    
    // Methods
    public void AddProduct(string name, double price, int quantity)
    {
        productName.Add(name);
        productQuantity.Add(quantity);
        productPrice.Add(price);
    }
    
    // Constructor
    public ProductData()
    {
        productName = new List<string>();
        productQuantity = new List<int>();
        productPrice = new List<double>();
    }
    
    // Functions
   
    public List<Product> GetAllProductData()
    {
        List<Product> assemblyProducts = new List<Product>();
        for (int i = 0; i < productName.Count; i++)
        {
            assemblyProducts.Add(new Product(productName[i],  productQuantity[i], productPrice[i]));
        }
        return assemblyProducts;
    }
   
    
    // Destructor
    ~ProductData()
    {
        productName = null;
        productQuantity = null;
        productPrice = null;
    }
}
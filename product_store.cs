namespace cs_oppgave_01;

public class ProductStore
{
    // Fields
    public List<string>? productName { get; set; } = new List<string>();
    public List<List<int>>? productQuantities { get; set; } = new List<List<int>>();
    public List<float>? productPrice { get; set; } = new List<float>();
    
    // Constructor
    public void AddProduct(string name, List<int> quantities, float price)
    {
        productName.Add(name);
        productQuantities.Add(quantities);
        productPrice.Add(price);
    }
    
    // Methods === Functions
    public List<ProductItem> GetAllProductData()
    {
        List<ProductItem> assemblyProducts = new List<ProductItem>();
        for (int i = 0; i < productName.Count; i++)
        {
            assemblyProducts.Add(new ProductItem(productName[i], productQuantities[i], productPrice[i]));
        }
        return assemblyProducts;
    }
    
    // Destructor
    ~ProductStore()
    {
        productName = null;
        productQuantities = null;
        productPrice = null;
    }
}
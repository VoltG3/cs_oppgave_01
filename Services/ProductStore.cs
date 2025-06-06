namespace cs_oppgave_01;

public class ProductStore : IProductStore
{
    // Fields
    public List<string>? productName { get; set; } = new List<string>();
    public List<float>? productPrice { get; set; } = new List<float>();
    public List<List<int>>? productQuantities { get; set; } = new List<List<int>>();
    
    // Constructor
    public void AddProduct(string name, List<int> quantities, float price)
    {
        productName.Add(name);
        productPrice.Add(price);
        productQuantities.Add(quantities);
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
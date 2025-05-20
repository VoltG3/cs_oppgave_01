// See https://aka.ms/new-console-template for more information
namespace cs_oppgave_01;

class Program
{
    // Simulating incoming *.json data
    private static string[][] _productDataJSON = new string[][]
    {
        new string[] { "HDD", "100,65", "1000" },
        new string[] { "SSD", "200,32", "2000" },
        new string[] { "RAM", "300,98", "3000" },
        new string[] { "CPU", "400,75", "4000" }
    };
    
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Clear();
        TextFormat.Space(1);
        
        ProductData productData = new ProductData();
        
        for (int i = 0; i < _productDataJSON.Length; i++)
        {
            productData.AddProduct(_productDataJSON[i][0], double.Parse(_productDataJSON[i][1]), int.Parse(_productDataJSON[i][2]));
        }
        
        productData.PrintProductData();
        
        //
        var products = productData.GetAllProductData();
        ProductPrinter.PrintTable(products);
       
        TextFormat.Space(1);
        
        // List<string> Add, Remove, Find, Sort, Reverse, Count, IndexOf, Contains,
    }
}
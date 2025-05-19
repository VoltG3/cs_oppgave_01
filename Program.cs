// See https://aka.ms/new-console-template for more information
namespace cs_oppgave_01;

class Program
{
    // Simulating incoming *.json data
    private static string[][] _productData = new string[][]
    {
        new string[] { "HDD", "100,65", "1000" },
        new string[] { "SSD", "200,32", "2000" },
        new string[] { "RAM", "300,98", "3000" },
    };
    
    static void Main(string[] args)
    {
        Console.Clear();
        
        ProductData productData = new ProductData();
        
        for (int i = 0; i < _productData.Length; i++)
        {
            productData.AddProduct(_productData[i][0], double.Parse(_productData[i][1]), int.Parse(_productData[i][2]));
        }
        
        productData.PrintProductData();
       
    }
}
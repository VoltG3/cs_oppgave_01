// See https://aka.ms/new-console-template for more information
namespace cs_oppgave_01;
using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("libmymodule.so", EntryPoint = "showMessage")]
    public static extern void ShowMessage();
    
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Clear();
        TextFormat.Space(1);
        
        string path="assets/products.json";
        var productsData = ReadFile.JsonData(path);
        
        ProductStore productStore = new ProductStore();

        for (int i = 0; i < productsData.Count; i++)
        {
            List<int> quantities = productsData[i].ProductQuantity
                .Values
                .Select(int.Parse)
                .ToList();
            float price = float.Parse(productsData[i].ProductPrice);
            string name = productsData[i].ProductName;
                    
            productStore.AddProduct(name, quantities, price);
        }
        
        List<ProductItem> allProducts = productStore.GetAllProductData();
        TextPrinter.PrintTable(allProducts);
        
       /*
        foreach (var product in allProducts)
        {
            Console.WriteLine($"Product: {product.Name}");
            Console.WriteLine($"Price: {product.Price}");
            Console.WriteLine("Quantities:");
            for (int i = 0; i < product.Quantities.Count; i++)
            {
                Console.WriteLine($"  {i + 1}: {product.Quantities[i]}");
            }
            Console.WriteLine();
        }
        */
        TextFormat.Space(1);
        ShowMessage();
        
        // List<string> Add, Remove, Find, Sort, Reverse, Count, IndexOf, Contains,
    }
}
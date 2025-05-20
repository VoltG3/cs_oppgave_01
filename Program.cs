// See https://aka.ms/new-console-template for more information
namespace cs_oppgave_01;
using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("libmymodule.so", EntryPoint = "showMessage")]
    public static extern void ShowMessage();
    
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
        
        // Onload Products data
        ProductData productData = new ProductData();
        
        for (int i = 0; i < _productDataJSON.Length; i++)
        {
            productData.AddProduct(_productDataJSON[i][0], int.Parse(_productDataJSON[i][2]), float.Parse(_productDataJSON[i][1]));
        }
        // end Onload Products data
        
        var products = productData.GetAllProductData();
        ProductPrinter.PrintTable(products);
       
        TextFormat.Space(1);
        ShowMessage();
        
        // List<string> Add, Remove, Find, Sort, Reverse, Count, IndexOf, Contains,
    }
}
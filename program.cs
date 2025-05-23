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
        
        // ####################
        //  C++ implementation
        // ####################
        
        TextFormat.Space(1);
        Console.Write($"{TextFormat.PaddingRight(5)}");
        
        ShowMessage();
        
        TextFormat.Space(1);
        
        // ####################
        //  Onload *.JSON data
        // ####################
        
        string path="assets/products.json";
        var productsData = FileReader.JsonData(path);
        
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
        
        // ###################
        //  Print out Results
        // ###################
        
        List<ProductItem> allProducts = productStore.GetAllProductData();
        ProductBalanse.Print(allProducts);
        PriceAligning.Print(allProducts);
        AllFields.Print(allProducts);
        
        TextFormat.Space(1);
    }
}
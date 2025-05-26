// See https://aka.ms/new-console-template for more information

using cs_oppgave_01;

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
        
        string path="Assets/products.json";
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
        
        // ###########################
        //  Random Generatet Products
        // ###########################
        
        float min01 = 299.99f;
        float max01 = 999.99f;
        string GName01 = "RandomGeneratet Product 01";
        float RPrice01 = RandomProduct.RandomPrice(min01, max01);
        List<int> RQuantities01 = new List<int> { 1000, 900, 800, 700, 600, 500, 400 };
        productStore.AddProduct(GName01, RQuantities01, RPrice01);
        
        float min02 = 299.99f;
        float max02 = 999.99f;
        string GName02 = "RandomGeneratet Product 02";
        float RPrice02 = RandomProduct.RandomPrice(min02, max02);
        List<int> RQuantities02 = new List<int> { 100, 90, 80, 70, 60, 50, 40 };
        productStore.AddProduct(GName02, RQuantities02, RPrice02);
        
        float min03 = 299.99f;
        float max03 = 999.99f;
        string GName03 = "RandomGeneratet Product 03";
        float RPrice03 = RandomProduct.RandomPrice(min03, max03);
        List<int> RQuantities03 = new List<int> { 10, 9, 8, 7, 6, 5, 4 };
        productStore.AddProduct(GName03, RQuantities03, RPrice03);
        
        /*
        float min01 = 99.99f;
        float max01 = 99999.99f;
        string GName01 = "RandomGeneratet Product 01";
        List<int> RQuantities01 = new List<int> { 1000, 900, 800, 700, 600, 500, 400 };
        float RPrice01 = RandomProduct.RandomPrice(min01, max01);
        productStore.AddProduct(GName01, RQuantities01, RPrice01);
        
        float min02 = 199.99f;
        float max02 = 9999.99f;
        string GName02 = "RandomGeneratet Product 02";
        List<int> RQuantities02 = new List<int>();
        RQuantities02.Add(10000);
        RQuantities02.Add(RandomProduct.RandomQuantity(RQuantities02[0]));
        RQuantities02.Add(RandomProduct.RandomQuantity(RQuantities02[1]));
        RQuantities02.Add(RandomProduct.RandomQuantity(RQuantities02[3]));
        RQuantities02.Add(RandomProduct.RandomQuantity(RQuantities02[4]));
        RQuantities02.Add(RandomProduct.RandomQuantity(RQuantities02[5]));
        RQuantities02.Add(RandomProduct.RandomQuantity(RQuantities02[6]));
        
        float RPrice02 = RandomProduct.RandomPrice(min02, max02);
        productStore.AddProduct(GName01, RQuantities02, RPrice02);
        float min03 = 299.99f;
        float max03 = 999.99f;
        string GName03 = "RandomGeneratet Product 03";
        List<int> RQuantities03 = new List<int> { 1000, 900, 800, 700, 600, 500, 400 };
        float RPrice03 = RandomProduct.RandomPrice(min03, max03);
        productStore.AddProduct(GName01, RQuantities03, RPrice03);
        */
        
        // ###################
        //  Print out Results
        // ###################
        
        List<ProductItem> allProducts = productStore.GetAllProductData();
        ProductBalanse.Print(allProducts);
        PriceAligning.Print(allProducts);
        //Debugging.Print(allProducts);   
        
        TextFormat.Space(1);
    }
}
namespace cs_oppgave_01;

public record Product(string Name, int Quantity, double Price);
public class ProductPrinter
{
    // Print the product data
    public static void PrintTable(List<Product> products)
    {
        // header
        Console.WriteLine($"    " + 
                          $"{ (char)9556 }" +
                          $"{ TextFormat.PrintHorizontalLine(26) }" +
                          $"{ (char)9574 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9574 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9559} " +
                          $"");
        
        Console.WriteLine($"    " +
                          $"{ (char)9553, -2 }" +$"{ "Product", -25 }" + 
                          $"{ (char)9553, -2 }" +$"{ "Quantity", -10 }" +
                          $"{ (char)9553, -2 }" +$"{ "Price", -10 }" + 
                          $"{ (char)9553 }");
        
        Console.WriteLine($"    " + 
                          $"{ (char)9567 }" +
                          $"{ TextFormat.PrintHorizontalLine(26) }" +
                          $"{ (char)9580 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9580 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9571 } " +
                          $"");
        
        // content
        for (int i = 0; i < products.Count; i++)
        {
            PrintProduct(products[i]);
        }
        
        // footer
        Console.WriteLine($"    " + 
                          $"{ (char)9562 }" +
                          $"{ TextFormat.PrintHorizontalLine(26) }" +
                          $"{ (char)9577 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9577 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9565 } " +
                          $"");
    }

    // Print each line of the product data
    private static void PrintProduct(Product product)
    {
            Console.WriteLine($"    " +
                              $"{ (char)9553, -2 }" + $"{ TextFormat.ExtractProductName(product.Name), -25 }" + 
                              $"{ (char)9553, -2 }" + $"{ product.Quantity, -10 }" +
                              $"{ (char)9553, -2 }" + $"{ product.Price, -10 }" + 
                              $"{ (char)9553, -2 }");
        
    }
}
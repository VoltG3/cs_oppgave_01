namespace cs_oppgave_01;

public class TextPrinter
{
    public static void PrintTable(List<ProductItem> products)
    {
        // table header
        Console.WriteLine($" { TextFormat.PaddingRight(4) }" + 
                          $"{ (char)9556 }" +
                          $"{ TextFormat.PrintHorizontalLine(26) }" +
                          $"{ (char)9574 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9574 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9559} " +
                          $"");
        
        Console.WriteLine($"{ TextFormat.PaddingRight(5) }" +
                          $"{ (char)9553, -2 }" +$"{ "Product", -25 }" + 
                          $"{ (char)9553, -2 }" +$"{ "Quantity", -10 }" +
                          $"{ (char)9553, -2 }" +$"{ "Price", -10 }" + 
                          $"{ (char)9553 }");
        
        Console.WriteLine($"{ TextFormat.PaddingRight(5) }" + 
                          $"{ (char)9567 }" +
                          $"{ TextFormat.PrintHorizontalLine(26) }" +
                          $"{ (char)9580 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9580 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9571 } " +
                          $"");
        
        // table content


        foreach (var product in products)
        {
            string q1 = product.Quantities[0].ToString();
            string q2 = product.Quantities[1].ToString();
            string q3 = product.Quantities[2].ToString();
            string q4 = product.Quantities[3].ToString();
            string q5 = product.Quantities[4].ToString();
            
            Console.WriteLine($"{ TextFormat.PaddingRight(5) }" +
                              $"{ (char)9553, -2 }{ product.Name, -25 }" +
                              $"{ (char)9553 }{ q1, 6 }" + $"{ (char)160 }" +
                              $"{ (char)9553 }{ q2, 6 }" + $"{ (char)160 }" +
                              $"{ (char)9553 }{ q3, 6 }" + $"{ (char)160 }" +
                              $"{ (char)9553 }{ q4, 6 }" + $"{ (char)160 }" +
                              $"{ (char)9553 }{ q5, 6 }" + $"{ (char)160 }" +
                              $"{ (char)9553, -2 }{ product.Price, -10 }" +
                              $"{ (char)9553 }");
        }
        
        // table footer
        Console.WriteLine($"{ TextFormat.PaddingRight(5) }" + 
                          $"{ (char)9562 }" +
                          $"{ TextFormat.PrintHorizontalLine(26) }" +
                          $"{ (char)9577 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9577 }" +
                          $"{ TextFormat.PrintHorizontalLine(11) }" +
                          $"{ (char)9565 } " +
                          $"");
    }
}
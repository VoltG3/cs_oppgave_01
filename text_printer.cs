namespace cs_oppgave_01;

public class TextPrinter
{
    public static void PrintTable(List<ProductItem> products)
    {
        
        // ##############
        //  table header
        // ##############
        
        Console.WriteLine($" { TextFormat.PaddingRight(4) }" + 
                          $"{ (char)9556 }" +
                          $"{ TextFormat.PrintHorizontalLine(28) }" +
                          $"{ (char)9574 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9572 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9572 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9572 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9572 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9572 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9572 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9559 }" +
                          // header section price
                          $"{ TextFormat.PaddingRight(3) }" +
                          $"{ (char)9556 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9574 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9574 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9559 }" +
                          $"");
                          
        string d0 = "store";
        string d1 = "jan";
        string d2 = "feb";
        string d3 = "mar";
        string d4 = "apr";
        string d5 = "mai";
        string d6 = "jun";
        
        Console.WriteLine($"{ TextFormat.PaddingRight(5) }" +
                          $"{ (char)9553, -2 }" +$"{ "Product", -27 }" + 
                          $"{ (char)9553, -2 }" + $"{ TextFormat.Color.CY }" + $"{ d0, -6 }" + $"{ TextFormat.Color.RS }" +
                          $"{ (char)9474, -3 }" + $"{ d1, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d2, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d3, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d4, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d5, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d6, -5 }" +
                          $"{ (char)9553 }" +
                          // header section price
                          $"{ TextFormat.PaddingRight(3) }" +
                          $"{ (char)9553, -2 }" + $"{ "default price", -14 }" +
                          $"{ (char)9553, -2 }" + $"{ "status action", -14 }" +
                          $"{ (char)9553, -2 }" + $"{ "aligned price", -14 }" +
                          
                          $"{ (char)9553 }");
        
        Console.WriteLine($"{ TextFormat.PaddingRight(5) }" + 
                          $"{ (char)9567 }" +
                          $"{ TextFormat.PrintHorizontalLine(28) }" +
                          $"{ (char)9580 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9578 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9578 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9578 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9578 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9578 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9578 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9571 }" +
                          /* header section price */
                          $"{ TextFormat.PaddingRight(3) }" + 
                          $"{ (char)9568 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9580 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9580 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9571 }" +
                          $"");
        
        // ###############
        //  table content
        // ###############
        
        foreach (var product in products)
        {
            string q0 = product.Quantities[0].ToString();
            string q1 = product.Quantities[1].ToString();
            string q2 = product.Quantities[2].ToString();
            string q3 = product.Quantities[3].ToString();
            string q4 = product.Quantities[4].ToString();
            string q5 = product.Quantities[5].ToString();
            string q6 = product.Quantities[6].ToString();
            
            // stack
            // too much left
            // too less left
            // nothing less
            // no action
            
            Console.WriteLine($"{ TextFormat.PaddingRight(5) }" +
                              $"{ (char)9553, -2 }{ TextFormat.ExtractProductPrefix( product.Name ), -27 }" +
                              $"{ (char)9553 }" + $"{ TextFormat.Color.CY }" + $"{ q0, 6 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ q1, 6 }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ q2, 6 }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ q3, 6 }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ q4, 6 }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ q5, 6 }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ q6, 6 }" + $"{ (char)160 }" + 
                              $"{ (char)9553 }" +
                              /* content section price */
                              $"{ TextFormat.PaddingRight(3) }" + 
                              $"{ (char)9553 }{ TextFormat.FormatPrice(product.Price), 10 }" + $" NoK" + $"{ (char)160 }" +
                              $"{ (char)9553 }{ "TODO", 14 }" + $"{ (char)160 }" +
                              $"{ (char)9553 }{ "TODO", 14 }" + $"{ (char)160 }" +
                              $"{ (char)9553 }");
        }
        
        // ##############
        //  table footer
        // ##############
        
        Console.WriteLine($"{ TextFormat.PaddingRight(5) }" + 
                          $"{ (char)9562 }" +
                          $"{ TextFormat.PrintHorizontalLine(28) }" +
                          $"{ (char)9577 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9575 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9575 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9575 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9575 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9575 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9575 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9565 }" +
                          /* footer section price */
                          $"{ TextFormat.PaddingRight(3) }" + 
                          $"{ (char)9562 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9577 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9577 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9565 }" +
                          $"");
    }
}
namespace cs_oppgave_01;

public class ProductBalanse
{
    public static void Print(List<ProductItem> products)
    {
        // ##############
        //  table header 
        // ##############

        string n1 = "- product decrease: normal flow";
        string n2 = "- product decrease: warning, to slowly";
        string n3 = "- product decrease: danger, flow stack";
        string n4 = "- product decrease: perfect flow";
        
        Console.WriteLine($"{TextFormat.PaddingRight(5) }" + $"{ TextColors.Color.CY } PRODUCT QUANTITY BALANSE { TextColors.Color.RS}");
        Console.WriteLine($"{TextFormat.PaddingRight(6) }" + $"{ TextColors.Color.CY }" + $"{ TextFormat.PrintSingleLine(94)}" + $"{ TextColors.Color.RS }");
        Console.WriteLine($"{TextFormat.PaddingRight(10)}" + $"{"compare each 'month' with .prev'month'"}");
        Console.WriteLine($"{TextFormat.PaddingRight(10)}" + $"{"RES: compare 'store' with last 'mont'"}");
        //TextFormat.Space(1);
        Console.WriteLine($"{TextFormat.PaddingRight(6)}" + $"{ TextColors.Color.CY }" + $"{ (char)9632 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" + $"{ n1 }");
        Console.WriteLine($"{TextFormat.PaddingRight(6)}" + $"{ TextColors.Color.PR }" + $"{ (char)9632 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" + $"{ n2 }");
        Console.WriteLine($"{TextFormat.PaddingRight(6)}" + $"{ TextColors.Color.RD }" + $"{ (char)9632 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" + $"{ n3 }");
        Console.WriteLine($"{TextFormat.PaddingRight(6)}" + $"{ TextColors.Color.YL }" + $"{ (char)9632 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" + $"{ n4 }");
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" + 
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
                          $"{ (char)9574 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9559 }" +
                          $"");
                          
        string d0 = "store";
        string d1 = "jan";
        string d2 = "feb";
        string d3 = "mar";
        string d4 = "apr";
        string d5 = "mai";
        string d6 = "jun";
        string d13 = "RES";
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" +
                          $"{ (char)9553, -2 }" + $"{ "Product", -27 }" + 
                          $"{ (char)9553, -2 }" + $"{ TextColors.Color.CY }" + $"{ d0, -6 }" + $"{ TextColors.Color.RS }" +
                          $"{ (char)9474, -3 }" + $"{ d1, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d2, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d3, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d4, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d5, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d6, -5 }" +
                          $"{ (char)9553, -3 }" + $"{ TextColors.Color.CY }" + $"{ d13, -5 }" + $"{ TextColors.Color.RS }" +
                          $"{ (char)9553 }" +
                          $"");
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" + 
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
                          $"{ (char)9580 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
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
            
            Console.WriteLine($"{ TextFormat.PaddingRight(6) }" +
                              $"{ (char)9553, -2 }{ TextFormat.ExtractProductPrefix( product.Name ), -27 }" +
                              $"{ (char)9553 }" + $"{ TextColors.Color.CY }" + $"{ q0, 6 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q0,  q1) }" + $"{ q1, 6 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" + 
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q1,  q2) }" + $"{ q2, 6 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q2,  q3) }" + $"{ q3, 6 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q3,  q4) }" + $"{ q4, 6 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q4,  q5) }" + $"{ q5, 6 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q5,  q6) }" + $"{ q6, 6 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9553 }{ TextColors.QuantityBalanceResult(q0,  q6) }" + $"{ q6, 6 }" + $"{ TextColors.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9553 }" +
                              $"");
        }
        
        // ##############
        //  table footer 
        // ##############
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" + 
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
                          $"{ (char)9577 }" +
                          $"{ TextFormat.PrintHorizontalLine(7) }" +
                          $"{ (char)9565 }" +
                          $"");
    }
}
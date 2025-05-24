namespace cs_oppgave_01;

public class ProductBalanse
{
    public static void Print(List<ProductItem> products)
    {
        // ##############
        //  table header 
        // ##############

        string h00 = "PRODUCT QUANTITY BALANSE";
        string h01 = "compare each 'month' with .prev'month'";
        string h02 = "RES: compare 'store' with last 'mont'";
        string h03 = "- product decrease: normal flow";
        string h04 = "- product decrease: warning, to slowly";
        string h05 = "- product decrease: danger, flow stack";
        string h06 = "- product decrease: perfect flow";
        
        Console.WriteLine($"{ TextFormat.PaddingRight(05) }{ TextColors.Color.CY }{ h00 }{ TextColors.Color.RS}");
        Console.WriteLine($"{ TextFormat.PaddingRight(06) }{ TextColors.Color.CY }{ TextFormat.PrintHorizontalSingleLine(94)}{ TextColors.Color.RS }");
        Console.WriteLine($"{ TextFormat.PaddingRight(10) }{ h01 }");
        Console.WriteLine($"{ TextFormat.PaddingRight(10) }{ h02 }");
        Console.WriteLine($"{ TextFormat.PaddingRight(06) }{ TextColors.Color.CY }{ (char)9632 }{ TextColors.Color.RS }{ (char)160 }{ h03 }");
        Console.WriteLine($"{ TextFormat.PaddingRight(06) }{ TextColors.Color.PR }{ (char)9632 }{ TextColors.Color.RS }{ (char)160 }{ h04 }");
        Console.WriteLine($"{ TextFormat.PaddingRight(06) }{ TextColors.Color.RD }{ (char)9632 }{ TextColors.Color.RS }{ (char)160 }{ h05 }");
        Console.WriteLine($"{ TextFormat.PaddingRight(06) }{ TextColors.Color.YL }{ (char)9632 }{ TextColors.Color.RS }{ (char)160 }{ h06 }");
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" + 
                          $"{ (char)9556 }{ TextFormat.PrintHorizontalDoubleLine(28)}" +
                          $"{ (char)9574 }{ TextFormat.PrintHorizontalDoubleLine(7) }" +
                          $"{ (char)9572 }{ TextFormat.PrintHorizontalDoubleLine(7) }" +
                          $"{ (char)9572 }{ TextFormat.PrintHorizontalDoubleLine(7) }" +
                          $"{ (char)9572 }{ TextFormat.PrintHorizontalDoubleLine(7) }" +
                          $"{ (char)9572 }{ TextFormat.PrintHorizontalDoubleLine(7) }" +
                          $"{ (char)9572 }{ TextFormat.PrintHorizontalDoubleLine(7) }" +
                          $"{ (char)9572 }{ TextFormat.PrintHorizontalDoubleLine(7) }" +
                          $"{ (char)9574 }{ TextFormat.PrintHorizontalDoubleLine(7) }" +
                          $"{ (char)9559 }");
                          
        string d00 = "store";
        string d01 = "jan";
        string d02 = "feb";
        string d03 = "mar";
        string d04 = "apr";
        string d05 = "mai";
        string d06 = "jun";
        string d13 = "RES";
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" +
                          $"{ (char)9553, -2 }{ "Product", -27 }" + 
                          $"{ (char)9553, -2 }{ TextColors.Color.CY }{ d00, -6 }{ TextColors.Color.RS }" +
                          $"{ (char)9474, -3 }{ d01, -5 }" +
                          $"{ (char)9474, -3 }{ d02, -5 }" +
                          $"{ (char)9474, -3 }{ d03, -5 }" +
                          $"{ (char)9474, -3 }{ d04, -5 }" +
                          $"{ (char)9474, -3 }{ d05, -5 }" +
                          $"{ (char)9474, -3 }{ d06, -5 }" +
                          $"{ (char)9553, -3 }{ TextColors.Color.CY }{ d13, -5 }{ TextColors.Color.RS }" +
                          $"{ (char)9553 }");
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" + 
                          $"{ (char)9567 }{ TextFormat.PrintHorizontalDoubleLine(28) }" +
                          $"{ (char)9580 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9578 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9578 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9578 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9578 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9578 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9578 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9580 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9571 }");
        
        // ###############
        //  table content 
        // ###############
        
        foreach (var product in products)
        {
            string q00 = product.Quantities[0].ToString();
            string q01 = product.Quantities[1].ToString();
            string q02 = product.Quantities[2].ToString();
            string q03 = product.Quantities[3].ToString();
            string q04 = product.Quantities[4].ToString();
            string q05 = product.Quantities[5].ToString();
            string q06 = product.Quantities[6].ToString();
            
            Console.WriteLine($"{ TextFormat.PaddingRight(6) }" +
                              $"{ (char)9553, -2 }{ TextFormat.ReplaceTextProductPrefix( product.Name ), -27 }" +
                              $"{ (char)9553 }{ TextColors.Color.CY }{ q00, 6 }{ TextColors.Color.RS }{ (char)160 }" +
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q00,  q01) }{ q01, 6 }{ TextColors.Color.RS }{ (char)160 }" + 
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q01,  q02) }{ q02, 6 }{ TextColors.Color.RS }{ (char)160 }" +
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q02,  q03) }{ q03, 6 }{ TextColors.Color.RS }{ (char)160 }" +
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q03,  q04) }{ q04, 6 }{ TextColors.Color.RS }{ (char)160 }" +
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q04,  q05) }{ q05, 6 }{ TextColors.Color.RS }{ (char)160 }" +
                              $"{ (char)9474 }{ TextColors.QuantityBalance(q05,  q06) }{ q06, 6 }{ TextColors.Color.RS }{ (char)160 }" +
                              $"{ (char)9553 }{ TextColors.QuantityBalanceResult(q00,  q06) }{ q06, 6 }{ TextColors.Color.RS }{ (char)160 }" +
                              $"{ (char)9553 }");
        }
        
        // ##############
        //  table footer 
        // ##############
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" + 
                          $"{ (char)9562 }{ TextFormat.PrintHorizontalDoubleLine(28) }" +
                          $"{ (char)9577 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9575 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9575 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9575 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9575 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9575 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9575 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9577 }{ TextFormat.PrintHorizontalDoubleLine(07) }" +
                          $"{ (char)9565 }");
    }
}
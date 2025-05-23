namespace cs_oppgave_01;

public class TextPrinter
{
    public static void ProductBalance(List<ProductItem> products)
    {
        // ################################
        //  table header || ProductBalance
        // ################################

        string n1 = "- product decrease: normal flow";
        string n2 = "- product decrease: warning, to slowly";
        string n3 = "- product decrease: danger, flow stack";
        string n4 = "- product decrease: perfect flow";
        
        Console.WriteLine($"{ TextFormat.PaddingRight(5) }" + $"{ TextFormat.Color.CY } PRODUCT QUANTITY BALANSE { TextFormat.Color.RS}");
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" + $"{ TextFormat.Color.CY }" + $"{ TextFormat.PrintSingleLine(94)}" + $"{ TextFormat.Color.RS }");
        Console.WriteLine($"{TextFormat.PaddingRight(10)}" + $"{"compare each 'month' with .prev'month'"}");
        Console.WriteLine($"{TextFormat.PaddingRight(10)}" + $"{"RES: compare 'store' with last 'mont'"}");
        //TextFormat.Space(1);
        Console.WriteLine($"{TextFormat.PaddingRight(6)}" + $"{ TextFormat.Color.CY }" + $"{ (char)9632 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" + $"{ n1 }");
        Console.WriteLine($"{TextFormat.PaddingRight(6)}" + $"{ TextFormat.Color.PR }" + $"{ (char)9632 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" + $"{ n2 }");
        Console.WriteLine($"{TextFormat.PaddingRight(6)}" + $"{ TextFormat.Color.RD }" + $"{ (char)9632 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" + $"{ n3 }");
        Console.WriteLine($"{TextFormat.PaddingRight(6)}" + $"{ TextFormat.Color.YL }" + $"{ (char)9632 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" + $"{ n4 }");
        
        Console.WriteLine($" { TextFormat.PaddingRight(5) }" + 
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
                          $"{ (char)9553, -2 }" + $"{ TextFormat.Color.CY }" + $"{ d0, -6 }" + $"{ TextFormat.Color.RS }" +
                          $"{ (char)9474, -3 }" + $"{ d1, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d2, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d3, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d4, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d5, -5 }" +
                          $"{ (char)9474, -3 }" + $"{ d6, -5 }" +
                          $"{ (char)9553, -3 }" + $"{ TextFormat.Color.CY }" + $"{ d13, -5 }" + $"{ TextFormat.Color.RS }" +
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
        
        // #################################
        //  table content || ProductBalance
        // #################################
        
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
                              $"{ (char)9553 }" + $"{ TextFormat.Color.CY }" + $"{ q0, 6 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ TextFormat.QuantityBalance(q0,  q1) }" + $"{ q1, 6 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" + 
                              $"{ (char)9474 }{ TextFormat.QuantityBalance(q1,  q2) }" + $"{ q2, 6 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ TextFormat.QuantityBalance(q2,  q3) }" + $"{ q3, 6 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ TextFormat.QuantityBalance(q3,  q4) }" + $"{ q4, 6 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ TextFormat.QuantityBalance(q4,  q5) }" + $"{ q5, 6 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474 }{ TextFormat.QuantityBalance(q5,  q6) }" + $"{ q6, 6 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9553 }{ TextFormat.QuantityBalanceResult(q0,  q6) }" + $"{ q6, 6 }" + $"{ TextFormat.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9553 }" +
                              $"");
        }
        
        // ################################
        //  table footer || ProductBalance
        // ################################
        
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

    public static void PriceAligning(List<ProductItem> products)
    {
        // ###############################
        //  table header || PriceAligning
        // ###############################
        
        TextFormat.Space(1);
        Console.WriteLine($"{TextFormat.PaddingRight(4) }" + $"{ TextFormat.Color.CY } PRICE ALIGNING BY FLOW TENDENCY { TextFormat.Color.RS}");
        Console.WriteLine($"{TextFormat.PaddingRight(6) }" + $"{ TextFormat.Color.CY }" + $"{ TextFormat.PrintSingleLine(94)}" + $"{ TextFormat.Color.RS }");
        Console.WriteLine($"{TextFormat.PaddingRight(10)}" + $"{ "price protection rank" }" + $"{ TextFormat.Color.RD }" + $"{ " HIG - " }" + $"{ TextFormat.Color.RS }" + $"{ "new price not less that 8000 NoK" }");
        Console.WriteLine($"{TextFormat.PaddingRight(10)}" + $"{ "price protection rank" }" + $"{ TextFormat.Color.CY }" + $"{ " MID - " }" + $"{ TextFormat.Color.RS }" + $"{ "new price not less that 4000 NoK" }");
        Console.WriteLine($"{TextFormat.PaddingRight(10)}" + $"{ "price protection rank" }" + $"{ TextFormat.Color.YL }" + $"{ " LOW - " }" + $"{ TextFormat.Color.RS }" + $"{ "none new price protection" }");
        
        Console.WriteLine($" { TextFormat.PaddingRight(5) }" + 
                          $"{ (char)9556 }" +
                          $"{ TextFormat.PrintHorizontalLine(28) }" +
                          $"{ (char)9574 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9574 }" +
                          $"{ TextFormat.PrintHorizontalLine(31) }" +
                          $"{ (char)9574 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9559 }" +
                          $"");
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" +
                          $"{ (char)9553, -2 }" + $"{ "Product", -27 }" + 
                          $"{ (char)9553, -2 }" + $"{ "Default Price", -14 }" +
                          $"{ (char)9553, -2 }" + $"{ "Price Protection Rang Action", -30 }" +
                          $"{ (char)9553, -2 }" + $"{ "Aligned Price", -14 }" +
                          $"{ (char)9553 }" +
                          $"");
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" + 
                          $"{ (char)9567 }" +
                          $"{ TextFormat.PrintHorizontalLine(28) }" +
                          $"{ (char)9580 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9580 }" +
                          $"{ TextFormat.PrintHorizontalLine(5) }" +
                          $"{ (char)9572}" +
                          $"{ TextFormat.PrintHorizontalLine(25) }" +
                          $"{ (char)9580 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9571 }" +
                          $"");
        
        // ################################
        //  table content || PriceAligning
        // ################################
        
        foreach (var product in products)
        
            // stack
            // too much left
            // too less left
            // nothing less
            // no action
            
            Console.WriteLine($"{ TextFormat.PaddingRight(6) }" +
                              $"{ (char)9553, -2 }{ TextFormat.ExtractProductPrefix( product.Name ), -27 }" +
                              $"{ (char)9553 }{ TextFormat.FormatPrice(product.Price), 10 }" + $" NoK" + $"{ (char)160 }" +
                              $"{ (char)9553, -2 }{ TextFormat.ExtractProtectionRankFlag(product.PriceProtectionRange)}{ TextFormat.ExtractProtextionRank(product.PriceProtectionRange), -3 }{ TextFormat.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474, -2 }" + $"{ "formula line", -24 }" +
                              $"{ (char)9553 }{ TextFormat.FormatPrice(product.DiscountPrice), 10 }" + $" NoK" + $"{ (char)160 }" +
                              $"{ (char)9553 }" +
                              $"");
        
        
        // ###############################
        //  table footer || PriceAligning
        // ###############################
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" + 
                          $"{ (char)9562 }" +
                          $"{ TextFormat.PrintHorizontalLine(28) }" +
                          $"{ (char)9577 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9577 }" +
                          $"{ TextFormat.PrintHorizontalLine(5) }" +
                          $"{ (char)9575 }" +
                          $"{ TextFormat.PrintHorizontalLine(25) }" +
                          $"{ (char)9577 }" +
                          $"{ TextFormat.PrintHorizontalLine(15) }" +
                          $"{ (char)9565 }" +
                          $"");
    }
}
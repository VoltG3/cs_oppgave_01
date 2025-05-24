namespace cs_oppgave_01;

public class PriceAligning
{
    public static void Print(List<ProductItem> products)
    {
        // ##############
        //  table header 
        // ##############
        
        string h00 = "PRICE ALIGNING BY FLOW TENDENCY";
        string h01 = "price protection rank";
        string h0a = " HIG - ";
        string h0b = " MED - ";
        string h0c = " LOW - ";
        string h02 = "new price not less that 8000 NoK";
        string h03 = "new price not less that 4000 NoK";
        string h04 = "none new price protection";
        
        TextFormat.Space(1);
        Console.WriteLine($"{ TextFormat.PaddingRight(04)}{ TextColors.Color.CY }{ h00 }{ TextColors.Color.RS}");
        Console.WriteLine($"{ TextFormat.PaddingRight(06)}{ TextColors.Color.CY }{ TextFormat.PrintHorizontalSingleLine(94)}{ TextColors.Color.RS }");
        Console.WriteLine($"{ TextFormat.PaddingRight(10)}{ h01 }{ TextColors.Color.RD }{ h0a }{ TextColors.Color.RS }{ h02 }");
        Console.WriteLine($"{ TextFormat.PaddingRight(10)}{ h01 }{ TextColors.Color.CY }{ h0b }{ TextColors.Color.RS }{ h03 }");
        Console.WriteLine($"{ TextFormat.PaddingRight(10)}{ h01 }{ TextColors.Color.YL }{ h0c }{ TextColors.Color.RS }{ h04 }");
        
        Console.WriteLine($" { TextFormat.PaddingRight(5) }" + 
                          $"{ (char)9556 }{ TextFormat.PrintHorizontalDoubleLine(28) }" +
                          $"{ (char)9574 }{ TextFormat.PrintHorizontalDoubleLine(15) }" +
                          $"{ (char)9574 }{ TextFormat.PrintHorizontalDoubleLine(31) }" +
                          $"{ (char)9574 }{ TextFormat.PrintHorizontalDoubleLine(15) }" +
                          $"{ (char)9559 }");
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" +
                          $"{ (char)9553, -2 }{ "Product", -27 }" + 
                          $"{ (char)9553, -2 }{ "Default Price", -14 }" +
                          $"{ (char)9553, -2 }{ "Price Protection Rang/Action", -30 }" +
                          $"{ (char)9553, -2 }{ "Aligned Price", -14 }" +
                          $"{ (char)9553 }");
        
        Console.WriteLine($"{ TextFormat.PaddingRight(6) }" + 
                          $"{ (char)9567 }{ TextFormat.PrintHorizontalDoubleLine(28) }" +
                          $"{ (char)9580 }{ TextFormat.PrintHorizontalDoubleLine(15) }" +
                          $"{ (char)9580 }{ TextFormat.PrintHorizontalDoubleLine(05) }" +
                          $"{ (char)9572 }{ TextFormat.PrintHorizontalDoubleLine(25) }" +
                          $"{ (char)9580 }{ TextFormat.PrintHorizontalDoubleLine(15) }" +
                          $"{ (char)9571 }");
        
        // ###############
        //  table content 
        // ###############

        foreach (var product in products)
        {
            string val = $"{ (char)160 }NoK";
            Console.WriteLine($"{ TextFormat.PaddingRight(6) }" +
                              $"{ (char)9553, -2 }{ TextFormat.FullProductName( product.Name ), -27 }" +
                              $"{ (char)9553 }{ TextColors.OldPriceFlag(product.Price, product.DiscountPrice) }{ TextFormat.FormatPrice(product.Price), 10 }{ val }{ (char)160 }" +
                              $"{ (char)9553, -2 }{ TextColors.RankFlag(product.DiscountRange)}{ TextFormat.RankFlag(product.DiscountRange), -3 }{ TextColors.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474, -2 }" + $"{ "formula line", -24 }" +
                              $"{ (char)9553 }{ TextColors.NewPriceFlag(product.Price, product.DiscountPrice) }{ TextFormat.FormatPrice(product.DiscountPrice), 10 }{ val }{ TextColors.Color.RS }{ (char)160 }" +
                              $"{ (char)9553 }" +
                              $"");
        }
            // ##############
            //  table footer 
            // ##############
        
            Console.WriteLine($"{ TextFormat.PaddingRight(6) }" + 
                              $"{ (char)9562 }{ TextFormat.PrintHorizontalDoubleLine(28) }" +
                              $"{ (char)9577 }{ TextFormat.PrintHorizontalDoubleLine(15) }" +
                              $"{ (char)9577 }{ TextFormat.PrintHorizontalDoubleLine(5) }" +
                              $"{ (char)9575 }{ TextFormat.PrintHorizontalDoubleLine(25) }" +
                              $"{ (char)9577 }{ TextFormat.PrintHorizontalDoubleLine(15) }" +
                              $"{ (char)9565 }");
    }
}
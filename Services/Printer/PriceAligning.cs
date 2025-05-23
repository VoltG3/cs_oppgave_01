namespace cs_oppgave_01;

public class PriceAligning
{
    public static void Print(List<ProductItem> products)
    {
        // ##############
        //  table header 
        // ##############
        
        TextFormat.Space(1);
        Console.WriteLine($"{TextFormat.PaddingRight(4) }" + $"{ TextColors.Color.CY } PRICE ALIGNING BY FLOW TENDENCY { TextColors.Color.RS}");
        Console.WriteLine($"{TextFormat.PaddingRight(6) }" + $"{ TextColors.Color.CY }" + $"{ TextFormat.PrintSingleLine(94)}" + $"{ TextColors.Color.RS }");
        Console.WriteLine($"{TextFormat.PaddingRight(10)}" + $"{ "price protection rank" }" + $"{ TextColors.Color.RD }" + $"{ " HIG - " }" + $"{ TextColors.Color.RS }" + $"{ "new price not less that 8000 NoK" }");
        Console.WriteLine($"{TextFormat.PaddingRight(10)}" + $"{ "price protection rank" }" + $"{ TextColors.Color.CY }" + $"{ " MID - " }" + $"{ TextColors.Color.RS }" + $"{ "new price not less that 4000 NoK" }");
        Console.WriteLine($"{TextFormat.PaddingRight(10)}" + $"{ "price protection rank" }" + $"{ TextColors.Color.YL }" + $"{ " LOW - " }" + $"{ TextColors.Color.RS }" + $"{ "none new price protection" }");
        
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
        
        // ###############
        //  table content 
        // ###############

        foreach (var product in products)
        {
            // stack
            // too much left
            // too less left
            // nothing less
            // no action
            
            Console.WriteLine($"{ TextFormat.PaddingRight(6) }" +
                              $"{ (char)9553, -2 }{ TextFormat.ExtractProductPrefix( product.Name ), -27 }" +
                              $"{ (char)9553 }{ TextFormat.FormatPrice(product.Price), 10 }" + $" NoK" + $"{ (char)160 }" +
                              $"{ (char)9553, -2 }{ TextColors.ExtractProtectionRankFlag(product.DiscountRange)}{ TextFormat.ExtractProtextionRank(product.DiscountRange), -3 }{ TextColors.Color.RS }" + $"{ (char)160 }" +
                              $"{ (char)9474, -2 }" + $"{ "formula line", -24 }" +
                              $"{ (char)9553 }{ TextFormat.FormatPrice(product.PriceWithDiscount), 10 }" + $" NoK" + $"{ (char)160 }" +
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
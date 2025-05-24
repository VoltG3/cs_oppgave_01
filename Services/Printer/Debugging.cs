namespace cs_oppgave_01;

public class Debugging
{
    public static void Print(List<ProductItem> products)
    { 
        TextFormat.Space(1);
        Console.WriteLine(
            $"{ TextFormat.PaddingRight(6) }" + 
            $"{ "P.Name", -11 }" + 
            $"{ "R", -5 }" + 
            $"{ "Price-------", -11 }"+ 
            $"{ "Price W/Disc.", 17 }" + 
            $"{ "IsLow", -10 }" +
            $"{ "Left Stock %", -4 }" +
            $"");
        
        Console.WriteLine(
            $"{ TextFormat.PaddingRight(6) }" + 
            $"{ TextFormat.PrintHorizontalSingleLine(58) }" +
            $"");
        
        string f01 = ((char)160) + "NoK" + ((char)160);
        
        foreach (var product in products)
        {
            Console.WriteLine(
                $"{ TextFormat.PaddingRight(6) }" + 
                $"{ product.Name, -11 }" +
                $"{ product.DiscountRange, -4 }" +
                $"{ TextFormat.FormatPrice(product.Price), 9 }{ f01 }" +
                $"{ TextFormat.FormatPrice(product.PriceWithDiscount), 11}{ f01 }" +
                $"{ product.IsRemainingStockLow, -8 }" +
                $"{ product.RemainingStockPrecentage, -4 }" +
                $"");
        }
        
        TextFormat.Space(1);
        Console.WriteLine(
            $"{ TextFormat.PaddingRight(6) }" + 
            $"{ "Default", -10 }" + 
            $"{ "Januar", -10 }" + 
            $"{ "Februar", -10 }"+ 
            $"{ "Mars", -10 }" + 
            $"{ "April", -10 }" +
            $"{ "Mai", -10 }" +
            $"{ "Left Stock %", -10 }" +
            $"");
        
        Console.WriteLine(
            $"{ TextFormat.PaddingRight(6) }" + 
            $"{ TextFormat.PrintHorizontalSingleLine(58) }" +
            $"");
        
        foreach (var product in products)
        {
            Console.WriteLine(
                $"{ TextFormat.PaddingRight(1) }" + 
                $"{ product.GetAllRemainingStockPrecentage()[0], 10:F2}" +
                $"{ product.GetAllRemainingStockPrecentage()[1], 10:F2}" +
                $"{ product.GetAllRemainingStockPrecentage()[2], 10:F2}" +
                $"{ product.GetAllRemainingStockPrecentage()[3], 10:F2}" +
                $"{ product.GetAllRemainingStockPrecentage()[4], 10:F2}" +
                $"{ product.GetAllRemainingStockPrecentage()[5], 10:F2}" +
                $"{ product.GetAllRemainingStockPrecentage()[6], 10:F2}" +
                // 
                $"");
        }
    }
}
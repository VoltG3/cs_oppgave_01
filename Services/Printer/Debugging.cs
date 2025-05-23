namespace cs_oppgave_01;

public class Debugging
{
    public static void Print(List<ProductItem> products)
    { 
        TextFormat.Space(1);
        Console.WriteLine(
            $"{ TextFormat.PaddingRight(6) }" + 
            $"{ "P.Name", -11 }" + 
            $"{ "R", -4 }" + 
            $"{ "Price", -11 }"+ 
            $"{ "Price D.", -12 }" + 
            $"{ "IsLow", -8 }" +
            $"{ "Left Stock %", -4 }" +
            $"");
        
        Console.WriteLine(
            $"{ TextFormat.PaddingRight(6) }" + 
            $"{ TextFormat.PrintSingleLine(58) }" +
            $"");
        
        foreach (var product in products)
        {
            Console.WriteLine(
                $"{ TextFormat.PaddingRight(6) }" + 
                $"{ product.Name, -11 }" +
                $"{ product.DiscountRange, -4 }" +
                $"{ product.Price, -11 }" +
                $"{ product.PriceWithDiscount, -12 }" +
                $"{ product.IsRemainingStockLow, -8 }" +
                $"{ product.RemainingStockPrecentage, -4 }" +
                $"");
        } 
    }
}
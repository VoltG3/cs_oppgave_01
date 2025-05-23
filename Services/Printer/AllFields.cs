namespace cs_oppgave_01;

public class AllFields
{
    public static void Print(List<ProductItem> products)
    { 
        Console.WriteLine($"{"Name", -10}" + $"{"DisRange",-10}"+ $"{"Price",-10}"+ $"{"PriceWDisc",-10}"+ $"{"IsLow",-10}"+$"{"RemStock%",-10}");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Name,-10}{product.DiscountRange,-10}{ product.Price, -10} { product.PriceWithDiscount, -10} { product.IsRemainingStockLow, -10}{ product.RemainingStockPrecentage, -10}");
        } 
    }
}
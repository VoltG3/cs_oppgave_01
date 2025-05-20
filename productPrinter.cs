namespace cs_oppgave_01;

public record Product(string Name, double Price, int Quantity);
public class ProductPrinter
{
    public static void PrintTable(List<Product> products)
    {
        for (int i = 0; i < products.Count; i++)
        {
            PrintProduct(products[i]);
        }
    }

    private static void PrintProduct(Product product)
    {
        Console.WriteLine($"Name: {product.Name}, Price: {product.Price:C}, Quantity: {product.Quantity}");

    }
}

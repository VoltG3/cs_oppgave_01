namespace cs_oppgave_01;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

public class ReadFile
{
    public class ProductRawData
    {
        [JsonPropertyName("product_name")]
        public string? ProductName { get; set; }
        [JsonPropertyName("product_price")]
        public string? ProductPrice { get; set; }
        [JsonPropertyName("product_quantity")]
        public Dictionary<string, string> ProductQuantity { get; set; }
    }
    public static List<ProductRawData> JsonData(string path)
    {
        try
        {
            var json = File.ReadAllText(path, Encoding.UTF8);
            return JsonSerializer.Deserialize<List<ProductRawData>>(json);
        }
        catch (Exception e)
        {
            Console.WriteLine($"[!] Error: { e.Message }");
            return new List<ProductRawData>();
        }
    }
}
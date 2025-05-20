namespace cs_oppgave_01;

public class ProductItem
{
    public string Name { get; set; }
    public List<int> Quantities { get; set; }
    public float Price { get; set; }
    
    public ProductItem(string name, List<int> quantities, float price)
    {
        Name = name;
        Quantities = quantities;
        Price = price;
    }
}
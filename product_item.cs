namespace cs_oppgave_01;

public class ProductItem
{
    public string Name { get; set; }
    public List<int> Quantities { get; set; }
    public float Price { get; set; }
    
    public int PriceProtectionRange => Price > 8000 ? 1 : Price > 4000 ? 2 : 3;
    
    public ProductItem(string name, List<int> quantities, float price)
    {
        Name = name;
        Quantities = quantities;
        Price = price;
    }

    public bool Temp(int taget)
    {
        var a = Quantities[0] - taget;
        return a > 0;
    }
}
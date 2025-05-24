namespace cs_oppgave_01;

public interface IProductItem
{   /// <summary>
    /// Product Name
    /// </summary>
    string Name { get; set; }
    
    /// <summary>
    /// List of product-left item count: each month
    /// </summary>
    List<int> FlowStock { get; set; }
    
    /// <summary>
    /// Product Price
    /// </summary>
    float Price { get; set; }
    
    /// <summary>
    ///  Defines possible price discount ranges
    /// </summary>
    int DiscountRange { get; }
    
    /// <summary>
    /// Price aligning: new price with discount
    /// </summary>
    float DiscountPrice { get; }
    
    /// <summary>
    /// Calculates the remaining stock quantity as a percentage of the initial stock
    /// </summary>
    float FinalStockPct { get; }
    
    /// <summary>
    /// If the remaining stock quantity is less than 10, the product is considered low on stock
    /// </summary>
    bool IsLowStock { get; }
}
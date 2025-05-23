namespace cs_oppgave_01;

public interface IProductStore
{   
    /// <summary>
    ///  Collection of all product objects
    /// </summary>
    /// <returns>All stored product objects: ProductItem</returns>
    List<ProductItem> GetAllProductData();
}
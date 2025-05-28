using BusinessObjects.Models;

namespace Services;

public interface IProductService
{
    void SaveProduct(Product product);
    void DeleteProduct(Product product);
    void UpdateProduct(Product product);
    List<Product> GetProducts();
    Product GetProductById(int id);
}
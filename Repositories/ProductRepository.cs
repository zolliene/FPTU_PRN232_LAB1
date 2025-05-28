using BusinessObjects.Models;
using DataAccessObjects;

namespace Repositories;

public class ProductRepository : IProductRepository
{
    public void SaveProduct(Product product)
    {
        ProductDAO.SaveProduct(product);
    }

    public void DeleteProduct(Product product)
    {
        ProductDAO.DeleteProduct(product);
    }

    public void UpdateProduct(Product product)
    {
        ProductDAO.UpdateProduct(product);
    }

    public List<Product> GetProducts()
    {
        return ProductDAO.GetProducts();
    }

    public Product GetProductById(int id)
    {
        return ProductDAO.GetProductById(id);
    }
}
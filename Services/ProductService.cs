using BusinessObjects.Models;
using Repositories;

namespace Services;

public class ProductService : IProductService
{

    private readonly IProductRepository _productRepository;

    public ProductService()
    {
        _productRepository = new ProductRepository();
    }
    
    public void SaveProduct(Product product)
    {
        _productRepository.SaveProduct(product);
    }

    public void DeleteProduct(Product product)
    {
        _productRepository.DeleteProduct(product);
    }

    public void UpdateProduct(Product product)
    {
        _productRepository.UpdateProduct(product);
    }

    public List<Product> GetProducts()
    {
        return _productRepository.GetProducts();
    }

    public Product GetProductById(int id)
    {
        return _productRepository.GetProductById(id);
    }
}
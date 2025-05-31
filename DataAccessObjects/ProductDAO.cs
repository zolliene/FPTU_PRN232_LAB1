using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects;

public class ProductDAO
{
    public static List<Product> GetProducts()
    {
        var listProducts = new List<Product>();
        try
        {
            using var db = new MyStoreContext();
            listProducts = db.Products.Include(f=>f.Category).ToList();
        }
        catch (Exception e){}
        return listProducts;
    }

    public static void SaveProduct(Product p)
    {
        try
        {
            using var context = new MyStoreContext();
            context.Products.Add(p);
            context.SaveChanges();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public static void UpdateProduct(Product p)
    {
        try
        {
            using var context = new MyStoreContext();
            context.Entry<Product>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public static void DeleteProduct(Product p)
    {
        try
        {
            using var context = new MyStoreContext();
            var p1 = context.Products.SingleOrDefault(c => c.ProductId == p.ProductId);
            context.Products.Remove(p1);
            context.SaveChanges();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public static Product GetProductById(int id)
    {
        using var db = new MyStoreContext();
       return db.Products.Include(c=>c.Category).FirstOrDefault(c => c.ProductId.Equals(id));
        //var p1=   db.Products
        //            .Include(p => p.Category)
        //            .FirstOrDefaultAsync(p => p.ProductId == id);
        //return p1;

    }
}
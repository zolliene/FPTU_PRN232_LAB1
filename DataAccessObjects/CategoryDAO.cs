using BusinessObjects.Models;

namespace DataAccessObjects;

public class CategoryDAO
{
    public static List<Category> GetCategories()
    {
        var listCategory = new List<Category>();
        try
        {
            using var context = new MyStoreContext();
            listCategory = context.Categories.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return listCategory;
    }
}
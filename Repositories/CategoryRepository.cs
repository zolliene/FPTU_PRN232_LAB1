using BusinessObjects.Models;
using DataAccessObjects;

namespace Repositories;

public class CategoryRepository : ICategoryRepository
{
    public List<Category> GetCategories() => CategoryDAO.GetCategories();
}
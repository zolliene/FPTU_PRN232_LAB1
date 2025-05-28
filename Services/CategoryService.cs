using BusinessObjects.Models;
using Repositories;

namespace Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService()
    {
        _categoryRepository = new CategoryRepository();
    }

    public List<Category> GetCategories()
    {
        return _categoryRepository.GetCategories();
    }
}
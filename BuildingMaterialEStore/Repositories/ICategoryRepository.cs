using BuildingMaterialEStore.Models.Product;
using System.Collections.Generic;

namespace BuildingMaterialEStore.Repositories
{
    public interface ICategoryRepository
    {
        Category FindCategoryById(long id);
        IEnumerable<Category> GetAllCategories();
        void SaveCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}

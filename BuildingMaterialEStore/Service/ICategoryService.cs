using BmesRestApi.Messages.Request.Category;
using BmesRestApi.Messages.Response.Category;

namespace BuildingMaterialEStore.Service
{
    public interface ICategoryService
    {
        CreateCategoryResponse SaveCategory(CreateCategoryRequest createCategoryRequest);
        UpdateCategoryResponse EditCategory(UpdateCategoryRequest updateCategoryRequest);
        GetCategoryResponse GetCategory(GetCategoryRequest getCategoryRequest);
        FetchCategoriesResponse GetCategories(FetchCategoryRequest fetchCategoryRequest);
        DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest deleteCategoryRequest);
    }
}

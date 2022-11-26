using BuildingMaterialEStore.Messages.DataTransferObjects.Product;
using BuildingMaterialEStore.Messages.Response.Product;

namespace BmesRestApi.Messages.Response.Category
{
    public class UpdateCategoryResponse : ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}

using BuildingMaterialEStore.Messages.DataTransferObjects.Product;
using BuildingMaterialEStore.Messages.Response.Product;

namespace BmesRestApi.Messages.Response.Product
{
    public class UpdateProductResponse : ResponseBase
    {
        public ProductDto Product { get; set; }
    }
}

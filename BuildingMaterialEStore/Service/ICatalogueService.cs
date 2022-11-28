using BmesRestApi.Messages.Request.Product;
using BmesRestApi.Messages.Response.Product;

namespace BuildingMaterialEStore.Service
{
    public interface ICatalogueService
    {
        FetchProductsResponse FetchProducts(FetchProductsRequest fetchProductsRequest);
    }
}

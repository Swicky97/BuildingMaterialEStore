using BmesRestApi.Messages.Response.Brand;
using BuildingMaterialEStore.Messages.Requests.Brand;
using BuildingMaterialEStore.Messages.Response.Brand;
using BuildingMaterialEStore.Service.Implementations;

namespace BuildingMaterialEStore.Service
{
    public interface IBrandService
    {
        CreateBrandResponse SaveBrand(CreateBrandRequest brandRequest);
        UpdateBrandResponse EditBrand(UpdateBrandRequest updateBrandRequest);
        GetBrandResponse GetBrand(GetBrandRequest getBrandRequest);
        FetchBrandsResponse GetBrands(FetchBrandsRequest fetchBrandsRequest);
        DeleteBrandResponse DeleteBrand(DeleteBrandRequest deleteBrandRequest);
    }
}

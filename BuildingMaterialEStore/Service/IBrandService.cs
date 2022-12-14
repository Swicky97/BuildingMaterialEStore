using BuildingMaterialEStore.Messages.Requests.Brand;
using BuildingMaterialEStore.Messages.Response.Brand;

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

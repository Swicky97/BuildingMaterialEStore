using BuildingMaterialEStore.Models.Product;
using System.Collections.Generic;

namespace BuildingMaterialEStore.Repositories
{
    public interface IBrandRepository
    {
        Brand FindBrandById(long id);
        IEnumerable<Brand> GetAllBrands();
        void SaveBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
    }
}

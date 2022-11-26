using BuildingMaterialEStore.Messages.DataTransferObjects.Product;
using BuildingMaterialEStore.Messages.Response.Product;

namespace BuildingMaterialEStore.Messages.Response.Brand
{
    public class UpdateBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}

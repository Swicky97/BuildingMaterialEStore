using BuildingMaterialEStore.Messages.DataTransferObjects.Product;
using BuildingMaterialEStore.Messages.Response.Product;

namespace BuildingMaterialEStore.Messages.Response.Brand
{
    public class GetBrandResponse : ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}

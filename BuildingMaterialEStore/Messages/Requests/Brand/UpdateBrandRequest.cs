using BuildingMaterialEStore.Messages.DataTransferObjects.Product;

namespace BuildingMaterialEStore.Messages.Requests.Brand
{
    public class UpdateBrandRequest
    {
        public int Id { get; set; }
        public BrandDto Brand { get; set; }
    }
}

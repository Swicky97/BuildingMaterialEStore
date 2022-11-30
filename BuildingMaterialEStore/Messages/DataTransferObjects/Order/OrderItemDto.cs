using BuildingMaterialEStore.Messages.DataTransferObjects.Product;

namespace BuildingMaterialEStore.Messages.DataTransferObjects.Order
{
    public class OrderItemDto
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }
    }
}

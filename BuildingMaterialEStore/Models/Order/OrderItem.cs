using BuildingMaterialEStore.Models.Product;
using BuildingMaterialEStore.Models.Shared;

namespace BuildingMaterialEStore.Messages.Requests.Order
{
    public class OrderItem : BaseObject
    {
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}

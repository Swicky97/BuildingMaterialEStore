using BuildingMaterialEStore.Messages.Response.Product;

namespace BuildingMaterialEStore.Messages.Response.Cart
{
    public class RemoveItemFromCartResponse : ResponseBase
    {
        public long CartItemId { get; set; }
    }
}

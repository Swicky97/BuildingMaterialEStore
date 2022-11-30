using BuildingMaterialEStore.Messages.DataTransferObjects.Cart;

namespace BuildingMaterialEStore.Messages.Request.Cart
{
    public class AddItemToCartRequest
    {
        public long CartId { get; set; }
        public CartItemDto CartItem { get; set; }
        public long ProductId { get; set; }
    }
}

using BuildingMaterialEStore.Messages.DataTransferObjects.Cart;
using BuildingMaterialEStore.Messages.Response.Product;

namespace BuildingMaterialEStore.Messages.Response.Cart
{
    public class AddItemToCartResponse : ResponseBase
    {
        public CartItemDto CartItem { get; set; }
    }
}

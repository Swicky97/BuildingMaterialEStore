using BuildingMaterialEStore.Messages.Request.Cart;
using BuildingMaterialEStore.Messages.Response.Cart;
using BuildingMaterialEStore.Models.Cart;
using System.Collections.Generic;

namespace BuildingMaterialEStore.Service
{
    public interface ICartService
    {
        AddItemToCartResponse AddItemToCart(AddItemToCartRequest addItemToCartRequest);
        RemoveItemFromCartResponse RemoveItemFromCart(RemoveItemFromCartRequest removeItemFromCartRequest);
        string UniqueCartId();
        Cart GetCart();
        FetchCartResponse FetchCart();
        IEnumerable<CartItem> GetCartItems();
        int CartItemsCount();
        decimal GetCartTotal();
    }
}

using BuildingMaterialEStore.Messages.Request.Cart;
using BuildingMaterialEStore.Messages.Response.Cart;
using BuildingMaterialEStore.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingMaterialEStore.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult<FetchCartResponse> GetCart()
        {
            var fetchCartResponse = _cartService.FetchCart();
            return fetchCartResponse;
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult<AddItemToCartResponse> AddItemToCart(AddItemToCartRequest addItemToCartRequest)
        {
            var addItemToCartResponse = _cartService.AddItemToCart(addItemToCartRequest);
            return addItemToCartResponse;
        }

        [AllowAnonymous]
        [HttpDelete("{cartId}/{cartItemId}")]
        public ActionResult<RemoveItemFromCartResponse> RemoveItemFromCart(long cartId, long cartItemId)
        {
            var removeItemFromCartRequest = new RemoveItemFromCartRequest { CartId = cartId, CartItemId = cartItemId };
            var removeItemFromCartResponse = _cartService.RemoveItemFromCart(removeItemFromCartRequest);
            return removeItemFromCartResponse;
        }
    }
}

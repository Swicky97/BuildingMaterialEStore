using BmesRestApi.Messages.Response.Checkout;
using BuildingMaterialEStore.Messages.Request.Checkout;
using BuildingMaterialEStore.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingMaterialEStore.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        private readonly ICheckoutService _checkoutService;
        public CheckoutController(ICheckoutService checkoutService)
        {
            _checkoutService = checkoutService;
        }

        [Authorize]
        [HttpPost]
        public ActionResult<CheckoutResponse> Checkout(CheckoutRequest checkoutRequest)
        {
            var checkoutResponse = _checkoutService.ProcessCheckout(checkoutRequest);
            return checkoutResponse;
        }
    }
}

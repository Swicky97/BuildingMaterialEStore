using BmesRestApi.Messages.Response.Checkout;
using BuildingMaterialEStore.Messages.Request.Checkout;

namespace BuildingMaterialEStore.Service
{
    public interface ICheckoutService
    {
        CheckoutResponse ProcessCheckout(CheckoutRequest checkoutRequest);
    }
}

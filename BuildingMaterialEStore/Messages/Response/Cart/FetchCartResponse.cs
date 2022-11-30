using BuildingMaterialEStore.Messages.DataTransferObjects.Cart;
using BuildingMaterialEStore.Messages.Response.Product;

namespace BuildingMaterialEStore.Messages.Response.Cart
{
    public class FetchCartResponse : ResponseBase
    {
        public CartDto Cart { get; set; }
    }
}

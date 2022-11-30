namespace BuildingMaterialEStore.Messages.Response.Order
{
    using BuildingMaterialEStore.Messages.Response.Product;
    using DataTransferObjects.Order;
    public class GetOrderResponse : ResponseBase
    {
        public OrderDto Order { get; set; }
    }
}

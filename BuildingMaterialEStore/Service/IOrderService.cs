using BuildingMaterialEStore.Messages.Request.Order;
using BuildingMaterialEStore.Messages.Response.Order;

namespace BuildingMaterialEStore.Service
{
    public interface IOrderService
    {
        GetOrderResponse GetOrder(GetOrderRequest getOrderRequest);
        FetchOrdersResponse GetOrders(FetchOrdersRequest fetchOrdersRequest);
    }
}

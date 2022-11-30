using BuildingMaterialEStore.Messages.Request.Order;
using BuildingMaterialEStore.Messages.Response.Order;
using BuildingMaterialEStore.Repositories;

namespace BuildingMaterialEStore.Service.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public GetOrderResponse GetOrder(GetOrderRequest getOrderRequest)
        {
            return new GetOrderResponse();
        }

        public FetchOrdersResponse GetOrders(FetchOrdersRequest fetchOrdersRequest)
        {
            return new FetchOrdersResponse();
        }
    }
}

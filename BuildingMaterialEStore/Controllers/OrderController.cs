using BuildingMaterialEStore.Messages.Request.Order;
using BuildingMaterialEStore.Messages.Response.Order;
using BuildingMaterialEStore.Service;
using Microsoft.AspNetCore.Mvc;

namespace BuildingMaterialEStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id}")]
        public ActionResult<GetOrderResponse> GetOrder(long id)
        {
            var getOrderRequest = new GetOrderRequest
            {
                Id = id
            };
            var getOrderResponse = _orderService.GetOrder(getOrderRequest);
            return getOrderResponse;
        }

        [HttpGet()]
        public ActionResult<FetchOrdersResponse> GetOrders()
        {
            var fetchOrdersRequest = new FetchOrdersRequest { };
            var fetchOrdersResponse = _orderService.GetOrders(fetchOrdersRequest);
            return fetchOrdersResponse;
        }
    }
}

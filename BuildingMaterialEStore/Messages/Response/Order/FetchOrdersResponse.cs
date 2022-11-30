namespace BuildingMaterialEStore.Messages.Response.Order
{
    using System.Collections.Generic;
    using BuildingMaterialEStore.Messages.Response.Product;
    using DataTransferObjects.Order;

    public class FetchOrdersResponse : ResponseBase
    {
        public int OrdersPerPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<OrderDto> Orders { get; set; }
    }
}

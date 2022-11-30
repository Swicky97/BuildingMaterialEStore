﻿using System.Collections.Generic;
using BuildingMaterialEStore.Models.Shared;
using BuildingMaterialEStore.Models.Customer;
using BuildingMaterialEStore.Models.Address;

namespace BuildingMaterialEStore.Messages.Requests.Order
{
    public class Order : BaseObject
    {
        public decimal OrderTotal { get; set; }
        public decimal OrderItemTotal { get; set; }
        public decimal ShippingCharge { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public long AddressId { get; set; }
        public Address DeliveryAddress { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}

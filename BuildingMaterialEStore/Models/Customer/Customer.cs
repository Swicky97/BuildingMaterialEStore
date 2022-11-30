using System.Collections.Generic;
using BuildingMaterialEStore.Messages.Requests.Order;

namespace BuildingMaterialEStore.Models.Customer
{
    using Shared;
    using Address;

    public class Customer : BaseObject
    {
        public long PersonId { get; set; }
        public Person Person { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}
  

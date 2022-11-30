using BuildingMaterialEStore.Messages.Requests.Order;
using System.Collections.Generic;

namespace BuildingMaterialEStore.Repositories
{
    public interface IOrderRepository
    {
        Order FindOrderById(long id);
        IEnumerable<Order> GetAllOrders();
        void SaveOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}

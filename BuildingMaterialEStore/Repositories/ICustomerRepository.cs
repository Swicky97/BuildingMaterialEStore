using BuildingMaterialEStore.Models.Customer;
using System.Collections.Generic;

namespace BuildingMaterialEStore.Repositories
{
    interface ICustomerRepository
    {
        Customer FindCustomerById(long id);
        IEnumerable<Customer> GetAllCustomers();
        void SaveCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}

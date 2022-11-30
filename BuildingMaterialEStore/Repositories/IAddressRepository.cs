using BuildingMaterialEStore.Models.Address;
using System.Collections.Generic;

namespace BuildingMaterialEStore.Repositories
{
    interface IAddressRepository
    {
        Address FindAddressById(long id);
        IEnumerable<Address> GetAllAddresses();
        void SaveAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddress(Address address);
    }
}

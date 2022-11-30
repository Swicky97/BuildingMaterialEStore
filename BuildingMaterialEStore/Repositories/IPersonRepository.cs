using BuildingMaterialEStore.Models.Shared;
using System.Collections.Generic;

namespace BuildingMaterialEStore.Repositories
{
    interface IPersonRepository
    {
        Person FindPersonById(long id);
        IEnumerable<Person> GetAllPeople();
        void SavePerson(Person person);
        void UpdatePerson(Person person);
        void DeletePerson(Person person);
    }
}

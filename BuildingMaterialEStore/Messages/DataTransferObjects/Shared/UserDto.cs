using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingMaterialEStore.Messages.DataTransferObjects.Shared
{
    public class UserDto
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
    }
}

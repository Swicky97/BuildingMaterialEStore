using Microsoft.AspNetCore.Identity;

namespace BuildingMaterialEStore.Models.Shared
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}


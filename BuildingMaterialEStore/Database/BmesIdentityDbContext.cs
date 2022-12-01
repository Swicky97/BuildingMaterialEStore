using BuildingMaterialEStore.Models.Shared;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BuildingMaterialEStore.Database
{
    public class BmesIdentityDbContext : IdentityDbContext<User>
    {
        public BmesIdentityDbContext(DbContextOptions<BmesIdentityDbContext> options) : base(options)
        {

        }
    }
}

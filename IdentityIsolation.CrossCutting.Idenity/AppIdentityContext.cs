using IdentityIsolation.CrossCutting.Idenity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityIsolation.CrossCutting.Idenity
{
    public class AppIdentityContext : IdentityDbContext<ApplicationUser>
    {
        public AppIdentityContext(DbContextOptions<AppIdentityContext> options) : base(options)
        {

        }
    }
}

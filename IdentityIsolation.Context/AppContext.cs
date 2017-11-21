using IdentityIsolation.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityIsolation.Context
{
    public class AppContext  : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Post { get; set; }
    }
}

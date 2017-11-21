using AppDbContext = IdentityIsolation.Context;

namespace IdentityIsolation.API
{
    public class AppDbContextFactory : DesignTimeDbContextFactory<AppDbContext.AppContext>
    {
    }
}

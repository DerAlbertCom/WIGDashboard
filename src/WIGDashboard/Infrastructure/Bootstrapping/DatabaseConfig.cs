using System.Data.Entity;
using Aperea.Infrastructure.Bootstrap;
using WIGDashboard.Core.Data;

namespace WIGDashboard.Infrastructure.Bootstrapping
{
    public class DatabaseConfig : BootstrapItem
    {
        public override void Execute()
        {
            Aperea.Data.DbContextFactory.SetDbContextType<WIGDbContext>();
            Database.SetInitializer(new DevelopmentDbContextInitializer());
        }
    }
}
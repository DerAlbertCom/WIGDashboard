using System.Data.Entity;

namespace WIGDashboard.Core.Data
{
    public class DevelopmentDbContextInitializer : DropCreateDatabaseIfModelChanges<WIGDbContext>
    {
         
    }
}
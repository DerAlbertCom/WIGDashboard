using System.Data.Entity;
using WIGDashboard.Core.Entities;

namespace WIGDashboard.Core.Data
{
    public class WIGDbContext : DbContext
    {
        public IDbSet<Group> Groups { get; set; }
        public IDbSet<Camera> Cameras { get; set; }
        public IDbSet<Router> Router { get; set; }
        public IDbSet<Storage> Storage { get; set; } 
    }
}
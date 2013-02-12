using Aperea.Data;
using StructureMap.Configuration.DSL;

namespace WIGDashboard.Core.Infrastructure.IoC
{
    public class CoreRegistry : Registry
    {
        public CoreRegistry()
        {
            For(typeof (IRepository<>)).HybridHttpOrThreadLocalScoped().Use(typeof (Repository<>));
            For<IDatabaseContext>().HybridHttpOrThreadLocalScoped().Use<DatabaseContext>();
        }
    }
}
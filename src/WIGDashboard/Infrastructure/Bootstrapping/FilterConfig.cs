using System;
using System.Web.Mvc;
using Aperea.Infrastructure.Bootstrap;
using WIGDashboard.Filters;

namespace WIGDashboard.Infrastructure.Bootstrapping
{
    public class FilterConfig : BootstrapItem
    {
        void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new DisposeDatabaseContextOnActionExecutedFilter());
        }

        public override void Execute()
        {
            RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
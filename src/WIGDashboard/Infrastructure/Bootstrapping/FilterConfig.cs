using System;
using System.Web.Mvc;
using Aperea.Infrastructure.Bootstrap;

namespace WIGDashboard.Infrastructure.Bootstrapping
{
    public class FilterConfig : BootstrapItem
    {
        void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public override void Execute()
        {
            RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
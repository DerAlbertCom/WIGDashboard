using System;
using System.Web.Mvc;
using System.Web.Routing;
using Aperea.Infrastructure.Bootstrap;

namespace WIGDashboard.Infrastructure.Bootstrapping
{
    public class RouteConfig : BootstrapItem
    {
       void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        public override void Execute()
        {
            RegisterRoutes(RouteTable.Routes);
        }
        public override int Order
        {
            get { return 20; }
        }
    }
}
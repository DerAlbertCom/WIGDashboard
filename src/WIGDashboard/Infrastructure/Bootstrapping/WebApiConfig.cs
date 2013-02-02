using System;
using System.Web.Http;
using Aperea.Infrastructure.Bootstrap;

namespace WIGDashboard.Infrastructure.Bootstrapping
{
    public class WebApiConfig : BootstrapItem
    {
        void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional}
                );

            config.EnableQuerySupport();
        }

        public override void Execute()
        {
            Register(GlobalConfiguration.Configuration);
        }

        public override int Order
        {
            get { return 10; }
        }
    }
}
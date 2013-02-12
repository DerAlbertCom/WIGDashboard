using System.Web.Mvc;
using Aperea.Data;
using Microsoft.Practices.ServiceLocation;

namespace WIGDashboard.Filters
{
    public class DisposeDatabaseContextOnActionExecutedFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ServiceLocator.Current.GetInstance<IDatabaseContext>().Dispose();
        }
    }
}
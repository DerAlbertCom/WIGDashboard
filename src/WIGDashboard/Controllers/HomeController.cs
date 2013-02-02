using System.Web.Mvc;

namespace WIGDashboard.Controllers
{
    public class HomeController : Controller
    {
         public ActionResult Index()
         {
             return View();
         }

        public ActionResult About()
        {
            throw new System.NotImplementedException();
        }

        public ActionResult Contact()
        {
            throw new System.NotImplementedException();
        }
    }
}
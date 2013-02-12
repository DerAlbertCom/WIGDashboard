using System;
using System.Linq;
using System.Web.Mvc;
using WIGDashboard.Core.Services;

namespace WIGDashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGroupDisplayService _service;

        public HomeController(IGroupDisplayService service)
        {
            this._service = service;
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.PageName = "Waltner IT Infrastruktur";
            return View(_service.GetMainGroups().ToList());
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

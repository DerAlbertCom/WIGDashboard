using System;
using System.Web.Mvc;

namespace WIGDashboard.Controllers
{
    public class InfrastructurController : Controller
    {
         public ActionResult Index()
         {
             return PartialView();
         }
    }
}
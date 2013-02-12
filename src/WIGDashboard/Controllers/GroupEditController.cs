using System;
using System.Linq;
using System.Web.Mvc;
using WIGDashboard.Core.Services;

namespace WIGDashboard.Controllers
{
    public class GroupEditController : AdminController
    {
        private readonly IGroupEditService _service;

        public GroupEditController(IGroupEditService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(_service.AllGroups().ToList());
        }
    }
}
using Monkeys.Project.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monkeys.Project.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            //IMasterUserService x = new MasterUserService();
            //var xxx = x.FindAll();

            return View();
        }
    }
}

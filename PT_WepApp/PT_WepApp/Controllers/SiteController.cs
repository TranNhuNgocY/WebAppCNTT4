using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyClass.Model;
using MyClass.DAO;

namespace PT_WepApp.Controllers
{
    public class SiteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}           
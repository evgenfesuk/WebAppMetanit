using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMetanit.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            ViewBag.Title = "Experimental page";
            ViewBag.Caption = "Big letters";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ogani.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Shop_Grid()
        {
            return View();
        }

        public ActionResult Shop_Details() 
        {
            return View();
        }

        public ActionResult Shoping_Cart()
        {
            return View();
        }

        public ActionResult Check_Out() 
        {
            return View();
        }

        public ActionResult Blog_Details() 
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
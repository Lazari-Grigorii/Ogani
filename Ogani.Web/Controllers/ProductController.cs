using Ogani.BusinessLogic;
using Ogani.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ogani.Web.Controllers
{
    public class ProductController : Controller
    {
        internal IProduct _product;
        public ProductController() 
        {
            var productBL = new BusinessLogic.BusinessLogic();
            _product = productBL.GetProductBL();
        }
        
        // GET: Product
        public ActionResult Index()
        {

            return View();
        }
    }
}
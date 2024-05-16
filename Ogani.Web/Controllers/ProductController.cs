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
            var bl  = new BusinessLogic.BusinessLogic();
            _product = bl.GetProduct();
        }


        // GET: Product
        public ActionResult Index()
        {       
            
            
            return View();
               }
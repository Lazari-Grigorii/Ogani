using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Ogani.Web
{
    public static class BundleGonfig
    {
         public static void RegisterBundles(BundleCollection bundles)
        {
            //Bootstrap style
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                "~/Vendors/css/bootstrap.min.css", new CssRewriteUrlTransform()));

            //Font Awesome icons style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                "~/Vendors/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            //JQuery style
            bundles.Add(new StyleBundle("~/bundles/jquery/css").Include(
                "~/Vendors/css/jquery-ui.min.css", new CssRewriteUrlTransform()));

            //Main style
            bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                "~/Vendors/css/style.css", new CssRewriteUrlTransform()));

            //Elegant icons style
            bundles.Add(new StyleBundle("~/bundles/elegant-icons/css").Include(
                "~/Vendors/css/elegant-icons.css", new CssRewriteUrlTransform()));

            //Nice select style
            bundles.Add(new StyleBundle("~/bundles/nice-select/css").Include(
                "~/Vendors/css/nice-select.css", new CssRewriteUrlTransform()));

            //Owl carousel style
            bundles.Add(new StyleBundle("~/bundles/owl.carousel/css").Include(
                "~/Vendors/css/owl.carousel.min.css", new CssRewriteUrlTransform()));

            //Slicknav style
            bundles.Add(new StyleBundle("~/bundles/slicknav/css").Include(
                "~/Vendors/css/slicknav.min.css", new CssRewriteUrlTransform()));

            
            
            
            
            //Bootstrap script
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                "~/Vendors/js/bootstrap.min.js"));

            //JQuery-3.3.1 script
            bundles.Add(new ScriptBundle("~/bundles/jquery-3.3.1/js").Include(
                "~/Vendors/js/jquery-3.3.1.min.js"));

            //JQuery nice-select script
            bundles.Add(new ScriptBundle("~/bundles/jquery.nice-select/js").Include(
                "~/Vendors/js/jquery.nice-select.min.js"));

            //JQuery-ui script
            bundles.Add(new ScriptBundle("~/bundles/jquery-ui/js").Include(
                "~/Vendors/js/jquery-ui.min.js"));

            //JQuery sclicknav script
            bundles.Add(new ScriptBundle("~/bundles/jquery.slicknav/js").Include(
                "~/Vendors/js/jquery.slicknav.js"));

            //Mixitup script
            bundles.Add(new ScriptBundle("~/bundles/mixitup/js").Include(
                "~/Vendors/js/mixitup.min.js"));

            //Owl carousel script
            bundles.Add(new ScriptBundle("~/bundles/owl.carousel/js").Include(
                "~/Vendors/js/owl.carousel.min.js"));

            //Main script
            bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                "~/Vendors/js/main.js"));
        }
    }
}
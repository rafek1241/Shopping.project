using System.Web;
using System.Web.Optimization;

namespace Shopping.Core
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/ej.theme.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/shop").IncludeDirectory("~/Content/Shop", "*.css",false));

            bundles.Add(new ScriptBundle("~/bundles/ejscripts").Include(
                           "~/Scripts/jsrender.min.js",
                           "~/Scripts/angular.js",
                           "~/Scripts/angular-route.js",
                            "~/Scripts/ej/ej.web.all.min.js",
                           "~/Scripts/jquery.easing-1.3.min.js",
                            "~/Scripts/ej/ej.widget.angular.min.js",
                            "~/Scripts/ej/ej.unobtrusive.min.js"));


            // ShopPage
            bundles.Add(new ScriptBundle("~/bundles/shop").Include("~/Areas/ShopPage/Scripts/Site.js")
                .IncludeDirectory("~/Areas/ShopPage/Scripts/Controllers", "*.js", true)
                .IncludeDirectory("~/Areas/ShopPage/Scripts/Directives", "*.js", true)
                .IncludeDirectory("~/Areas/ShopPage/Scripts/Services", "*.js", true));
        }
    }
}

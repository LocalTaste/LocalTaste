using System.Web;
using System.Web.Optimization;

namespace LocalTaste.Mvc
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

            bundles.Add(new ScriptBundle("~/bundles/themeScripts").Include(
                        "~/Scripts/jquery.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/easing.js",
                        "~/Scripts/filter.js",
                        "~/Scripts/jquery.carouFredSel-6.1.0-packed.js",
                        "~/Scripts/jquery.prettyPhoto.js",
                        "~/Scripts/jquery.flexslider-min.js",
                        "~/Scripts/jquery.isotope.js",
                        "~/Scripts/custom.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.css",
                      "~/Content/flexslider.css",
                      "~/Content/prettyPhoto.css",
                      "~/Content/style.css",
                      "~/Content/orange.css"));
        }
    }
}

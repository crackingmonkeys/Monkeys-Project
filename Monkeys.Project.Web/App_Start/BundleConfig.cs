using System.Web;
using System.Web.Optimization;

namespace Monkeys.Project.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            // Paper dashboard bootstrap scripts
            bundles.Add(new ScriptBundle("~/bundles/paper-dashboard-scripts").Include(
                        "~/Content/paper-dashboard/assets/js/jquery-1.10.2.js",
                        "~/Content/paper-dashboard/assets/js/bootstrap.min.js",
                        "~/Content/paper-dashboard/assets/js/bootstrap-checkbox-radio.js",
                        "~/Content/paper-dashboard/assets/js/chartist.min.js",
                        "~/Content/paper-dashboard/assets/js/bootstrap-notify.js",
                        "~/Content/paper-dashboard/assets/js/paper-dashboard.js",
                        "~/Content/paper-dashboard/assets/js/demo.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Paper dashboard bootstrap css
            bundles.Add(new StyleBundle("~/bundles/paper-dashboard-css").Include(
                      "~/Content/paper-dashboard/assets/css/bootstrap.min.css",
                      "~/Content/paper-dashboard/assets/css/animate.min.css",
                      "~/Content/paper-dashboard/assets/css/paper-dashboard.css",
                      "~/Content/paper-dashboard/assets/css/demo.css",
                      "~/Content/paper-dashboard/assets/css/themify-icons.css"));
        }
    }
}

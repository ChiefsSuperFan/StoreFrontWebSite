using System.Web;
using System.Web.Optimization;

namespace StoreFront
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //consolidate all of the script bundles 
            //and and references to the datatables js
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/DataTables/jquery.dataTables.min.js",
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/bootstrap.js", 
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //removed reference to Microsoft css and add the new bootstrap template
            //the css for datatables
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap-materia.min.css",
                      "~/Content/DataTables/css/dataTables.material.css",
                      "~/Content/site.css"));
        }
    }
}

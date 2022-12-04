using System.Web;
using System.Web.Optimization;

namespace app
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // js
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery.js"));;
            bundles.Add(new ScriptBundle("~/bundles/foundation").Include("~/Scripts/foundation.js"));
            bundles.Add(new ScriptBundle("~/bundles/app").Include("~/Scripts/app.js"));

            // css
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css")
                .Include("~/Content/foundation.css")
                .Include("~/Content/motion-ui.css")
            );
        }
    }
}

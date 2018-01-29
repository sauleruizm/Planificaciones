using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Ser.Planificaciones.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));//,"~/Scripts/jquery-{version}.slim.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/pace").Include(
                        "~/Scripts/pace.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/pixeladmin").Include(
                        "~/Scripts/pixeladmin.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                        "~/Scripts/knockout-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/require").Include(
                        "~/Scripts/require.js"));

            bundles.Add(new ScriptBundle("~/bundles/dashboard").Include(
                        "~/Scripts/dashboard.js"));


            //CSS

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                        "~/Content/bootstrap-theme.css",
                        "~/Content/bootstrap.css"));
            
            bundles.Add(new StyleBundle("~/Content/pixeladmin").Include(
                        "~/Content/pixeladmin.min.css", "~/Content/themes/default.min.css"));

            bundles.Add(new StyleBundle("~/Content/widgets").Include(
                        "~/Content/widgets.min.css"));

            bundles.Add(new StyleBundle("~/Content/clean").Include(
                       "~/Content/themes/clean.min.css"));

            bundles.Add(new StyleBundle("~/Content/ionicons").Include(
                       "~/Content/ionicons.css", "~/Content/font-awesome.css"));

        }
    }
}
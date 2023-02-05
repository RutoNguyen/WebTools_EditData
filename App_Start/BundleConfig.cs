using System.Web;
using System.Web.Optimization;

namespace TPF.FFTools
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/vendors/jquery/jquery-{version}.js"));
            bundles.Add(new Bundle("~/bundles/vendors").Include(

                        //"~/Scripts/vendors/angularjs/angular.js",

                        //"~/Scripts/vendors/angularjs/angular-route.js",
                        //"~/Scripts/vendors/angularjs/angular-animate.js",
                        //"~/Scripts/vendors/angularjs/angular-animate.min.js",
                        

                        //"~/Scripts/vendors/angular-ui-router/angular-ui-router.min.js",

                        /////////////////////////////
                        ///
                        ///angular
                        "~/Scripts/vendors/angularjs/angular.min.js",
                        //"~/Scripts/vendors/node_modules/angular/angular.js",
                        //"~/Scripts/vendors/node_modules/angular/angular.min.js",

                        ///route
                        "~/Scripts/vendors/angularjs/angular-route.min.js",

                        ///animate
                        "~/Scripts/vendors/angularjs/angular-animate.js",
                        "~/Scripts/vendors/angularjs/angular-animate.min.js",
                        //"~/Scripts/vendors/node_modules/angular-animate/angular-animate.min.js",
                        ///sanitize
                        "~/Scripts/vendors/angularjs/angular-sanitize.min.js",
                        ///Dialog
                        "~/Scripts/vendors/ngDialog/ngDialog.min.js",

                        ///toastr
                        ///
                        "~/Scripts/vendors/angular-toastr/angular-toastr.tpls.min.js",
                        //"~/Scripts/vendors/toastr/toastr.js",

                        ///toaster
                        //"~/Scripts/vendors/angularjs-toaster/toaster.min.js",

                        //"~/Scripts/vendors/node_modules/angular-sanitize/angular-sanitize.min.js",

                        ///confirm
                        "~/Scripts/vendors/angular-confirm/angular-confirm.min.js",

                        ///loading bar
                        "~/Scripts/vendors/angular-loadingbar/loading-bar.js",

                        ///ui-router
                        "~/Scripts/vendors/angular-ui-router/angular-ui-router.min.js",

                        ///moment
                        "~/Scripts/vendors/moment-js/moment.js",
                        //"~/Scripts/vendors/moment-js/moment.min.js",
                        "~/Scripts/vendors/moment-js/moment-with-locales.js",
                        ///bootstrap
                        "~/Scripts/bootstrap.bundle.min.js"
                        ));

            //bundles.Add(new Bundle("~/bundles/bootstrap").Include(
            //           "~/Scripts/bootstrap.js",SS
            //           "~/Scripts/respond.js"));
            //bundles.Add(new Bundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
            bundles.Add(new Bundle("~/scripts/core").Include("~/content/scripts/vendors/bootstrap/bootstrap.bundle.min.js"));

            bundles.Add(new Bundle("~/bundles/app").IncludeDirectory(
                        "~/App", "*.js", true));


            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));


            //bundles.Add(new Bundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new Bundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new Bundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new Bundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/angular-toastr/angular-toastr.min.css",
                      //"~/Scripts/vendors/angularjs-toaster/toaster.min.css",
                      //"~/Content/toastr/toastr.css",
                      "~/Scripts/vendors/angular-confirm/angular-confirm.min.css",
                      "~/Scripts/vendors/angular-loadingbar/loading-bar.css",
                      "~/Scripts/vendors/ngDialog/ngDialog.css",
                      "~/Scripts/vendors/ngDialog/ngDialog-theme-default.min.css"
                      ));
        }
    }
}

using System.Web;
using System.Web.Optimization;

namespace GoodsForAll
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/js/jquery-1.12.1.min.js",
                        "~/Scripts/js/popper.min.js",
                        "~/Scripts/js/bootstrap.min.js",
                        "~/Scripts/js/jquery.magnific-popup.js",
                        "~/Scripts/js/swiper.min.js",
                        "~/Scripts/js/wow.min.js",
                        "~/Scripts/js/jquery.smooth-scroll.min.js",
                        "~/Scripts/js/masonry.pkgd.js",
                        "~/Scripts/js/owl.carousel.min.js",
                        "~/Scripts/js/jquery.nice-select.min.js",
                        "~/Scripts/js/slick.min.js",
                        "~/Scripts/js/jquery.counterup.min.js",
                        "~/Scripts/js/waypoints.min.js",
                        "~/Scripts/js/jquery.ajaxchimp.min.js",
                        "~/Scripts/js/jquery.form.js",
                        "~/Scripts/js/jquery.validate.min.js",
                        "~/Scripts/js/mail-script.js",
                        "~/Scripts/js/contact.js",
                        "~/Scripts/js/custom.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/animate.css",
                      "~/css/owl.carousel.min.css",
                      "~/css/themify-icons.css",
                      "~/css/flaticon.css",
                      "~/css/magnific-popup.css",
                      "~/css/nice-select.css",
                      "~/css/slick.css",
                      "~/css/style.css",
                      "~/css/mystylesheet.css"
                      ));
        }
    }
}

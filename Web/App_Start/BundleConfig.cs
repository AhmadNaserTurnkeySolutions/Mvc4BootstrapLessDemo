using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Transformers;

namespace Mvc4BootstrapLessDemo
{
  using System.Web.Optimization;

  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      var cssTransformer = new CssTransformer();
      var jsTransformer = new JsTransformer();
      var nullOrderer = new NullOrderer();

      // jQuery
      var jqueryUiCss = new Bundle("~/bundles/jqueryuicss").Include(
        "~/Content/themes/base/jquery.ui.core.css",
        "~/Content/themes/base/jquery.ui.resizable.css",
        "~/Content/themes/base/jquery.ui.selectable.css",
        "~/Content/themes/base/jquery.ui.accordion.css",
        "~/Content/themes/base/jquery.ui.autocomplete.css",
        "~/Content/themes/base/jquery.ui.button.css",
        "~/Content/themes/base/jquery.ui.dialog.css",
        "~/Content/themes/base/jquery.ui.slider.css",
        "~/Content/themes/base/jquery.ui.tabs.css",
        "~/Content/themes/base/jquery.ui.datepicker.css",
        "~/Content/themes/base/jquery.ui.progressbar.css",
        "~/Content/themes/base/jquery.ui.theme.css");
      jqueryUiCss.Transforms.Add(cssTransformer);
      jqueryUiCss.Transforms.Add(new CssMinify());
      jqueryUiCss.Orderer = nullOrderer;
      bundles.Add(jqueryUiCss);

      var jq = new Bundle("~/bundles/jquery").Include(
        "~/Scripts/jquery-{version}.js",
        "~/Scripts/jquery-ui-{version}.js");
      jq.Transforms.Add(jsTransformer);
      jq.Orderer = nullOrderer;
      bundles.Add(jq);

      var js = new Bundle("~/bundles/js").Include(
        "~/Scripts/bootstrap.min.js",
        "~/Scripts/Prettify/prettify.js",
        "~/Scripts/application.js");
      js.Transforms.Add(jsTransformer);
      js.Orderer = nullOrderer;
      bundles.Add(js);

      var jqueryVal = new Bundle("~/bundles/jqueryval").Include(
        "~/Scripts/jquery.unobtrusive*",
        "~/Scripts/jquery.validate*");
      jqueryVal.Transforms.Add(jsTransformer);
      jqueryVal.Orderer = nullOrderer;
      bundles.Add(jqueryVal);

      // Css
      var css = new Bundle("~/bundles/css").Include(
        "~/Content/less/bootstrap.less",
        "~/Content/less/responsive.less",
        "~/Content/Prettify/prettify.css",
        "~/Content/docs.css",
        "~/Content/icons.css");
      css.Transforms.Add(cssTransformer);
      css.Transforms.Add(new CssMinify());
      css.Orderer = nullOrderer;
      bundles.Add(css);

      BundleTable.EnableOptimizations = true;
    }
  }
}
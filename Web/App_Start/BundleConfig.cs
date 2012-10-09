namespace Mvc4BootstrapLessDemo
{
  using System.Web.Optimization;

  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      // jQuery
      var jqueryUiCss = new StyleBundle("~/bundles/jqueryuicss").Include(
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
      jqueryUiCss.Transforms.Add(new CssMinify());
      bundles.Add(jqueryUiCss);

      var jqueryJs = new ScriptBundle("~/bundles/jquery").Include(
        "~/Scripts/jquery-1.*",
        "~/Scripts/jquery-ui*");
      jqueryJs.Transforms.Add(new JsMinify());
      bundles.Add(jqueryJs);

      var jqueryVal = new ScriptBundle("~/bundles/jqueryval").Include(
        "~/Scripts/jquery.unobtrusive*",
        "~/Scripts/jquery.validate*");
      jqueryVal.Transforms.Add(new JsMinify());
      bundles.Add(jqueryVal);

      // Default
      var defaultCss = new StyleBundle("~/bundles/css").Include(
        "~/Content/less/bootstrap.less",
        "~/Content/less/responsive.less",
        "~/Content/Prettify/prettify.css",
        "~/Content/docs.css");
      defaultCss.Transforms.Add(new LessMinify());
      bundles.Add(defaultCss);

      var defaultJs = new ScriptBundle("~/bundles/js").Include(
        "~/Scripts/bootstrap.js",
        "~/Scripts/Prettify/prettify.js",
        "~/Scripts/application.js");
      defaultJs.Transforms.Add(new JsMinify());
      bundles.Add(defaultJs);

      BundleTable.EnableOptimizations = true;
    }
  }
}
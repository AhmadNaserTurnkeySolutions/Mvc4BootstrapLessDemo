namespace Mvc4BootstrapLessDemo
{
  using System.Web.Optimization;

  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      // jQuery
      var jqueryUiCss = new StyleBundle("~/bundles/jqueryui.css").Include(
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

      var jqueryJs = new ScriptBundle("~/bundles/jquery.js").Include(
        "~/Scripts/jquery-1.*",
        "~/Scripts/jquery-ui*");
      jqueryJs.Transforms.Add(new JsMinify());
      bundles.Add(jqueryJs);

      // Boostrap
      var bootstrapCss = new StyleBundle("~/bundles/bootstrap.css").Include(
        "~/Content/less/bootstrap.less",
        "~/Content/less/responsive.less");
      bootstrapCss.Transforms.Add(new LessMinify());
      bundles.Add(bootstrapCss);

      var bootstrapJs = new ScriptBundle("~/bundles/bootstrap.js").Include(
        "~/Scripts/bootstrap.js");
      bootstrapJs.Transforms.Add(new JsMinify());
      bundles.Add(bootstrapJs);

      // Default
      var defaultCss = new StyleBundle("~/bundles/default.css").Include(
        "~/Content/Prettify/prettify.css",
        "~/Content/docs.css");
      defaultCss.Transforms.Add(new CssMinify());
      bundles.Add(defaultCss);

      var defaultJs = new ScriptBundle("~/bundles/default.js").Include(
        "~/Scripts/Prettify/prettify.js",
        "~/Scripts/application.js");
      defaultJs.Transforms.Add(new JsMinify());
      bundles.Add(defaultJs);

      BundleTable.EnableOptimizations = false;
    }
  }
}
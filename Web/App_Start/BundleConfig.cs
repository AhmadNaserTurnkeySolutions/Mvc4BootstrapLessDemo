namespace Mvc4BootstrapLessDemo
{
  using System.Web.Optimization;

  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      BundleTable.EnableOptimizations = true;

      // jQuery UI
      var jqueryUICss = new StyleBundle("~/jqueryui.css").Include(
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
      jqueryUICss.Transforms.Add(new CssMinify());
      bundles.Add(jqueryUICss);

      // Default
      var css = new StyleBundle("~/default.css").Include(
        "~/Content/less/bootstrap.less",
        "~/Content/less/responsive.less",
        "~/Content/prettify.css",
        "~/Content/site.css");
      css.Transforms.Add(new LessMinify());
      bundles.Add(css);

      var javascript = new ScriptBundle("~/default.js").Include(
        "~/Scripts/jquery-1.*",
        "~/Scripts/jquery-ui*",
        "~/Scripts/prettify.js",
        "~/Scripts/bootstrap.min.js",
        "~/Scripts/Main.js");
      javascript.Transforms.Add(new JsMinify());
      bundles.Add(javascript);
    }
  }
}
[assembly: WebActivator.PreApplicationStartMethod(typeof(Mvc4BootstrapLessDemo.AppActivator), "PreStart")]
[assembly: WebActivator.PostApplicationStartMethod(typeof(Mvc4BootstrapLessDemo.AppActivator), "PostStart")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(Mvc4BootstrapLessDemo.AppActivator), "Stop")]
namespace Mvc4BootstrapLessDemo
{
  using System.Web.Http;
  using System.Web.Mvc;
  using System.Web.Optimization;
  using System.Web.Routing;

  public static class AppActivator
  {
    public static void PreStart()
    {

    }

    public static void PostStart()
    {
      AppPostStart();
    }

    public static void Stop()
    {

    }

    private static void AppPostStart()
    {
      ViewEngines.Engines.Clear();
      ViewEngines.Engines.Add(new RazorViewEngine());

      AreaRegistration.RegisterAllAreas();

      WebApiConfig.Register(GlobalConfiguration.Configuration);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
      AuthConfig.RegisterAuth();
    }
  }
}
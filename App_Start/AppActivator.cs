[assembly: WebActivator.PreApplicationStartMethod(typeof(Mvc4BootstrapLessDemo.AppActivator), "PreStart")]
[assembly: WebActivator.PostApplicationStartMethod(typeof(Mvc4BootstrapLessDemo.AppActivator), "PostStart")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(Mvc4BootstrapLessDemo.AppActivator), "Stop")]
namespace Mvc4BootstrapLessDemo
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Web;
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

      RouteConfig.RegisterRoutes(RouteTable.Routes);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
    }
  }
}
using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc4BootstrapLessDemo
{
  public class RouteConfig
  {
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      // Account
      routes.MapRoute(
        RouteName.Login,
        "login",
        MVC.Account.Login());

      routes.MapRoute(
        RouteName.Logoff,
        "logoff",
        MVC.Account.LogOff());

      routes.MapRoute(
        RouteName.Register,
        "register",
        MVC.Account.Register());

      routes.MapRoute(
        RouteName.Profile,
        "account/profile",
        MVC.Account.Manage());

      // Home
      routes.MapRoute(
        RouteName.Home,
        "",
        MVC.Home.Index());

      // Pages
      routes.MapRoute(
        RouteName.GetStarted,
        "getstarted",
        MVC.Pages.GetStarted());

      routes.MapRoute(
        RouteName.Scaffolding,
        "scaffolding",
        MVC.Pages.Scaffolding());

      routes.MapRoute(
        RouteName.BaseCss,
        "basecss",
        MVC.Pages.BaseCss());

      routes.MapRoute(
        RouteName.Components,
        "components",
        MVC.Pages.Components());

      routes.MapRoute(
        RouteName.Javascript,
        "javascript",
        MVC.Pages.Javascript());

      routes.MapRoute(
        RouteName.Customize,
        "customize",
        MVC.Pages.Customize());

      routes.MapRoute(
        RouteName.Extend,
        "extend",
        MVC.Pages.Extend());

      routes.MapRoute(
        RouteName.ExamplesHero,
        "examples/hero",
        MVC.Pages.Hero());

      routes.MapRoute(
        RouteName.ExamplesFluid,
        "examples/fluid",
        MVC.Pages.Fluid());

      routes.MapRoute(
        RouteName.ExamplesStarter,
        "examples/starter",
        MVC.Pages.Starter());

      /* Not using catch all routes */
      routes.MapRoute(
          name: "Default",
          url: "{controller}/{action}/{id}",
          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
      );
    }
  }
}
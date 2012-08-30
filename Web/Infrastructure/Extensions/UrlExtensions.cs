namespace Mvc4BootstrapLessDemo
{
  using System.Web;
  using System.Web.Mvc;
  using System;
  
  public static class UrlExtensions
  {
    public static string Current(this UrlHelper url)
    {
      return url.RequestContext.HttpContext.Request.RawUrl;
    }

    public static string AbsoluteContent(this UrlHelper url, string path)
    {
      var uri = new Uri(path, UriKind.RelativeOrAbsolute);

      if (!uri.IsAbsoluteUri)
      {
        var builder = new UriBuilder(url.RequestContext.HttpContext.Request.Url) { Path = VirtualPathUtility.ToAbsolute(path) };
        uri = builder.Uri;
      }

      return uri.ToString();
    }

    public static string Login(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.Login);
    }

    public static string Register(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.Register);
    }

    public static string Profile(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.Profile);
    }

    public static string Home(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.Home);
    }

    public static string GetStarted(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.GetStarted);
    }

    public static string Scaffolding(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.Scaffolding);
    }

    public static string BaseCss(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.BaseCss);
    }

    public static string Components(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.Components);
    }

    public static string Javascript(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.Javascript);
    }

    public static string Customize(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.Customize);
    }

    public static string Extend(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.Extend);
    }

    public static string ExamplesHero(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.ExamplesHero);
    }

    public static string ExamplesFluid(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.ExamplesFluid);
    }

    public static string ExamplesStarter(this UrlHelper url)
    {
      return url.RouteUrl(RouteName.ExamplesStarter);
    }
  }
}
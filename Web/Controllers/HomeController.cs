using System.Web.Mvc;

namespace Mvc4BootstrapLessDemo.Controllers
{
  public partial class HomeController : Controller
  {
    public virtual ActionResult Index()
    {
      ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

      return View();
    }
  }
}

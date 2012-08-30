using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4BootstrapLessDemo.Controllers
{
  public partial class PagesController : Controller
  {
    public virtual ActionResult GetStarted()
    {
      return View();
    }

    public virtual ActionResult Scaffolding()
    {
      return View();
    }

    public virtual ActionResult BaseCss()
    {
      return View();
    }

    public virtual ActionResult Components()
    {
      return View();
    }

    public virtual ActionResult Javascript()
    {
      return View();
    }

    public virtual ActionResult Customize()
    {
      return View();
    }

    public virtual ActionResult Extend()
    {
      return View();
    }

    public virtual ActionResult Hero()
    {
      return View("examples/Hero");
    }

    public virtual ActionResult Fluid()
    {
      return View("examples/Fluid");
    }

    public virtual ActionResult Starter()
    {
      return View("examples/Starter");
    }
  }
}

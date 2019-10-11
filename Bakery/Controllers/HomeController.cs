using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
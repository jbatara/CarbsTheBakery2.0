
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendor/new")]
    public ActionResult AddNew(string name)
    {
      Vendor newVendor = new Vendor(name);
      return Redirect("/vendor");
    }
  }
}


using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/order")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/order/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/order/new")]
    public ActionResult AddNew()
    {
      return View();
    }
    [HttpGet("/vendor/{id}/order/new")]
    public ActionResult NewVendorOrder(string name)
    {
      return Redirect("/vendor/{id}");
    }
    [HttpGet("/vendor/{id}/order/new")]
    
    public ActionResult AddNewVendorOrder(string name)
    {
      Vendor newVendor = new Vendor(name);
      return Redirect("/vendor");
    }
  }
}

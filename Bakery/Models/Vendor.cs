using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{


  public class Vendor
  {
    static int _currentID = 1;
    static List<Vendor> _listOfVendors = new List<Vendor>();
    public string Name { get; set; }
    public int ID { get; set; }

    public List<Order> VendorOrders { get; set; }
    public List<Order> Pending {get;set;}
    public List<Order> Fulfilled {get;set;}

    public Vendor(string name)
    {
      ID = _currentID;
      Name = name;
      VendorOrders = new List<Order>();
      Pending = new List<Order>();
      Fulfilled = new List<Order>();
      _currentID++;
      _listOfVendors.Add(this);
    }

    public static List<Vendor> GetAll()
    {
      return _listOfVendors;
    }
    public static int GetCurrentID()
    {
      return _currentID;
    }

    public void AddOrder(Order t)
    {
      VendorOrders.Add(t);
    }

    public void DeleteOrder(int orderID)
    {
      int index = VendorOrders.FindIndex(o => o.ID == orderID);
      if (index >= 0)
      {
        VendorOrders.RemoveAt(index);
      }
    }

    public string PrintVendor()
    {
      string output = "<h3> <strong>Vendor:</strong> " + Name + "</h3><h3><strong>Vendor ID:</strong> " + ID + "</h3";
      output += "<h4>Orders</h4>";
      output += "<p><strong>Total Number of Orders:</strong> " + VendorOrders.Count;
      return output;

    }

  }
}
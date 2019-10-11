using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{


  public class Vendor
  {
    int _currentID = 1;
    List<Vendor> _listOfVendors = new List<Vendor>();
    public string Name { get; set; }
    public int ID { get; set; }

    public List<Transaction> VendorOrders { get; set; }

    public Vendor(string name)
    {
      ID = _currentID;
      Name = name;
      VendorOrders = new List<Transaction>();
      _currentID++;
      _listOfVendors.Add(this);
    }

    public void AddOrder(Transaction t)
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
      string output = "<h3> <strong>Vendor:</strong> " + Name + "<strong>Vendor ID:</strong> " + ID + "</h3";
      return output;

    }

  }
}
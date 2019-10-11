using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{

  public class Transaction {

    public int ID {get;set;}
    public List<Merchandise> Items {get;set;}
    public Dictionary<string,int> Quantity {get;set;}

    public double Total {get;set;}

    public Transaction(int currentTransactionID)
    {
      ID = currentTransactionID;
      Items = new List<Merchandise>();
      Quantity = new Dictionary<string,int>();
      Total = 0;
    }

    public double AddItem(Merchandise newItem)
    {
      
      if(Items.Any(item => item.Equals(newItem)))
      {
        Quantity[newItem.Type + ":" + newItem.Name]++;
      }
      else
      {
        Items.Add(newItem);
        Quantity[newItem.Type + ":" + newItem.Name] = 1;
      }
      Total = 0;
      foreach(Merchandise i in Items)
      {
        int quantity = Quantity[i.Type + ":" + i.Name];
        Total += i.Price * quantity;
      }
      List<double> discounts = BulkBuy();
      Total = Total-discounts[0]-discounts[1];
      return Total;
    }

    public double SubtractItem(Merchandise item)
    {
      if (Items.Any(i => item.Equals(i)))
      {
        if(Quantity[item.Type + ":" + item.Name] > 0)
        {
          Quantity[item.Type + ":" + item.Name]--;
          //remove item from list and dictionary if after you subtract, there are zero items
          if(Quantity[item.Type + ":" + item.Name]<= 0)
          {
            Items.Remove(item);
            Quantity.Remove(item.Type + ":" + item.Name);
          }
          Total-=item.Price;
        }
        else
        {
          Console.WriteLine("This item has a quantity of 0 or less. Cannot Subtract Item");
        }
      }
      else
      {
        Console.WriteLine("This item does not exist in the current transaction");
      }
      List<double> discounts = BulkBuy();
      foreach(double discount in discounts)
      {
        Total -= discount;
      }
      return Total;
    }

    public List<double> BulkBuy()
    {
      //bread buy 2 get one free ($5 each)
      //pastry 1/$2 or 3/$5
      int breadCounter = 0;
      int pastryCounter = 0;
      foreach(Merchandise item in Items)
      {
        if(item is Bread)
        {
          breadCounter+= Quantity[item.Type + ":" + item.Name];
        }
        else if (item is Pastry)
        {
          pastryCounter += Quantity[item.Type + ":" + item.Name];
        }
      }
      double breadDiscount = Math.Floor(breadCounter/3.0)*5;
      double pastryDiscount = Math.Floor(pastryCounter/3.0);
      List<double> discounts = new List<double>(){breadDiscount,pastryDiscount};
      return discounts;
    }

    public string PrintTransaction()
    {
      string output = "";
      output+="\n Transaction ID# " + ID;
      if(Items.Count>0)
      {
        for (var i = 0; i < Items.Count; i++)
        {
          int index = i+1;
         output+=("\n Item " + index + ". " + Items[i].Name + " Qty: " + Quantity[Items[i].Type + ":" + Items[i].Name]);
        }
      }
      List<double> discounts = BulkBuy();
      output+=("\n Bread Bulk Buy: -$" + discounts[0] + " Pastry Bulk Buy: -$" + discounts[1]);
      output+=("\n Total: $" + Total);
      
      return output;
    }

  }
}

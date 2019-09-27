using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery
{

  public class Transaction {

    public int ID {get;set;}
    public List<Merchandise> Items {get;set;}
    public Dictionary<string,int> Quantity {get;set;}

    public double Total {get;set;}

    public Transaction()
    {
      ID = Bakery.lastTransaction+1;
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
      Total += newItem.Price;
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
      return Total;
    }

    // public double calcPromotions()
    // {
    //   //bread buy 2 get one free ($5 each)
    //   //pastry 1/$2 or 3/$5
    // }

  }
}

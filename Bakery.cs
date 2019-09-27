using System;

namespace Bakery{

  public class Bakery{

    public static int lastTransaction=1;

    public static void Main()
    {
      BakedGood  pastry = new Bread("Yum");
      BakedGood pastry2 = new Pastry("Yum2");
      Console.WriteLine("Pastry Name: " + pastry.Name + "Pastry Price: " + pastry.Price + "Pastry Type: " + pastry.Type + " Pastry Bakery Type " + pastry.BakeryType);
      Console.WriteLine("Pastry and pastry 2 are equal: " + pastry.Equals(pastry2));

      Transaction trans = new Transaction();
      Console.WriteLine("Initial: "+trans.Total);
      trans.AddItem(pastry);
      Console.WriteLine("Add pastry: "+trans.Total);
      trans.AddItem(pastry2);
      Console.WriteLine("Add pastry2: "+trans.Total);
      foreach(Merchandise item in trans.Items)
      {
          Console.WriteLine(item.Name);
      }
      foreach(string key in trans.Quantity.Keys){
        Console.WriteLine(key + ", qty: "+trans.Quantity[key]);
      }
    }
  }

}
using System;

namespace Bakery{

  public class Bakery{

    public static void Main()
    {
      BakedGood  pastry = new Bread("Yum",12.50);
      BakedGood pastry2 = new Bread("Yum", 12.50);
      Console.WriteLine("Pastry Name: " + pastry.Name + "Pastry Price: " + pastry.Price + "Pastry Type: " + pastry.Type + " Pastry Bakery Type " + pastry.BakeryType);
      Console.WriteLine("Pastry and pastry 2 are equal: " + pastry.Equals(pastry2));
    }
dagfw
  }

}
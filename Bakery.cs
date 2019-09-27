using System;

namespace Bakery{

  public class Bakery{

    public static void Main()
    {
      BakedGood  pastry = new BakedGood("Yum",12.50);
      Console.WriteLine("Pastry Name: " + pastry.Name + "Pastry Price: " + pastry.Price + "Pastry Type: " + pastry.Type);
    }

  }

}
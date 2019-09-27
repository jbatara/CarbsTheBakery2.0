using System;

namespace Bakery
{

  public class Pastry: BakedGood
  {
    public Pastry(string name, double price)
      : base(name, price)
    {
      BakeryType = "Pastry";
    }

  }

}
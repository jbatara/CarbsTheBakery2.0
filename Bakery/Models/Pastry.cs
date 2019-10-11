using System;

namespace Bakery.Models
{

  public class Pastry: BakedGood
  {
    public Pastry(string name)
      : base(name, 2.00)
    {
      BakeryType = "pastry";
    }

  }

}
using System;

namespace Bakery
{

  public class BakedGood : Merchandise
  {

    // public string Name { get; set; }
    // public decimal Price { get; set; }

    public string BakeryType { get; set; }

    public BakedGood(string name, double price)
      :base(name,price)
    {
      Type = "Baked Good";
      BakeryType = "Unkown";
    }

  }

}
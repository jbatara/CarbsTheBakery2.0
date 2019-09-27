using System;

namespace Bakery
{

  public class Bread: BakedGood
  {

    public Bread(string name, double price)
      :base(name,price)
    {
      BakeryType = "Bread"; 
    }

  }

}
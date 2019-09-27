using System;

namespace Bakery
{

  public class Bread: BakedGood
  {

    public Bread(string name)
      :base(name,5.00)
    {
      BakeryType = "Bread"; 
    }

  }

}
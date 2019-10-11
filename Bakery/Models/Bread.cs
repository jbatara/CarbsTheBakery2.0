namespace Bakery.Models
{

  public class Bread: BakedGood
  {

    public Bread(string name)
      :base(name,5.00)
    {
      BakeryType = "bread"; 
    }

  }

}
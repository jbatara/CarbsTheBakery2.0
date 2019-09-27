using System;

namespace Bakery
{

  public class Merchandise
  {

    public string Name {get;set;}
    public double Price {get;set;}

    public string Type {get;set;}

    public Merchandise(string name, double price)
    {
      Name = name;
      Price = price;
      Type = "Unknown";
    }

    public override bool Equals(object value)
    {
      Merchandise item = value as Merchandise;

      return (item != null)
          && (Name == item.Name)
          && (Price == item.Price)
          && (this.GetType() == item.GetType());
    }

  }

}
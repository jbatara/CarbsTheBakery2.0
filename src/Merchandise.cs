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

  }

}
using System;
using System.Collections.Generic;

namespace Bakery{

  public class Bakery{

    private static int lastTransaction=1;

    public List<Transaction> Transactions {get;set;}
    
     List<BakedGood> bakedGoods;
     Dictionary<string,List<Merchandise>> menu;

    



    public static void Main()
    {
     
    }

    public static void POSMainMenu(){
      Console.WriteLine('\u2591'+'\u2591' + '\u2591' + '\u2591' + '\u2591' + "Main Menu"+'\u2591' + '\u2591' + '\u2591' + '\u2591' + '\u2591');
      Console.WriteLine("Start new transaction (s)");
      Console.WriteLine("View old transactions (vo)");
      Console.WriteLine("Edit old transactions (eo)");

      string userInput = Console.ReadLine().ToLower();

      if(userInput == "s")
      {
        POSNewTransaction();
      }
      else if (userInput == "vo")
      {
        POSOldTransactions();
      }
      else if (userInput == "eo")
      {
        POSEditTransaction();
      }
      else{
        "That's an invalid input."
        POSMainMenu();
      }
    }

    public static Transaction CreateTransaction()
    {
      lastTransaction++;
      return new Transaction(lastTransaction);
    }
  }

}
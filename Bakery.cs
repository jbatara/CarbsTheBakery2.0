using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery
{

  public class Bakery
  {

    private static int lastTransaction = 1;

    public List<Transaction> Transactions { get; set; }
    static Pastry doughnut = new Pastry("doughnut");
    static Pastry appleFritter = new Pastry("apple fritter");
    static Pastry croissont = new Pastry("croissont");
    static Pastry seasonalFruitTart = new Pastry("seasonal fruit tart");
    static Pastry strawberryTart = new Pastry("strawberry fruit tart");
    static List<Pastry> pastry = new List<Pastry>() { doughnut, appleFritter, croissont, seasonalFruitTart, strawberryTart };

    static Bread french = new Bread("french");
    static Bread sausageCurl = new Bread("sausage");
    static Bread gruyereChunkLoaf = new Bread("gruyere chunk");
    static Bread rosemaryGarlicLoaf = new Bread("rosemary garlic");
    static Bread rye = new Bread("rye");
    static Bread wheat = new Bread("wheat");
    static List<Bread> bread = new List<Bread>() { french, sausageCurl, gruyereChunkLoaf, rosemaryGarlicLoaf, rye, wheat };

    public static void Main()
    {

      List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
      var listSearch = list.Where(n => n >2);
      List<int> intList = listSearch.ToList();
      foreach(int i in intList)
      {
        Console.WriteLine(i);
      }
      
      // POSMainMenu();
    }

    public static void POSMainMenu()
    {
      Console.WriteLine("░░░░░░░░░░" + "Main Menu" + "░░░░░░░░░░");
      Console.WriteLine("| Start new transaction (s) | View old transactions (vo) | Edit old transactions (eo)|");

      string userInput = Console.ReadLine().ToLower();

      if (userInput == "s")
      {
        // POSNewTransaction();
      }
      else if (userInput == "vo")
      {
        POSOldTransactions();
      }
      else if (userInput == "eo")
      {
        POSEditTransaction();
      }
      else
      {
        Console.WriteLine("That's an invalid input.");
        POSMainMenu();
      }
    }

    public static void POSNewTransaction(int code)
    {
      //if code 0, new transaction. if code 1, then go back to the transaction menu again.
      // if(code == 0)
      // {
      //   Console.WriteLine("░░░░░░░░░░" + "New Transaction" + "░░░░░░░░░░");
      //   Transaction newTransaction = CreateTransaction();
      //   Console.WriteLine("░░░░" + "Transaction" + "░░░░");
      //   Console.WriteLine(newTransaction.PrintTransaction());
      //   Console.WriteLine("| Add an item (A) | Subtract Item (S) | See Transaction(T) | Finish Transaction(F) |");
      //   string userInput = Console.ReadLine().ToLower();
      //   if (userInput == "a")
      //   {
      //     Console.WriteLine("Input name of item to add.");
      //     string userItemName = Console.ReadLine();
      //     if(bread.Where(b => b.Name == userItemName)== 1)
      //     {

      //       newTransaction.AddItem()
      //     }
      //     else if (pastry.Where(p => p.Name == userItemName).Any())
      //     {

      //     }
      //   }
      //   else if (userInput == "s")
      // }
      // else if (code ==1)
      // {

    }


  

  public static void POSOldTransactions()
  {
    Console.WriteLine("░░░░░░░░░░" + "Previous Transactions" + "░░░░░░░░░░");
  }

  public static void POSEditTransaction()
  {
    Console.WriteLine("░░░░░░░░░░" + "Edit Transactions" + "░░░░░░░░░░");
  }

  public static Transaction CreateTransaction()
  {
    Transaction transaction = new Transaction(lastTransaction);
    lastTransaction++;
    return transaction;
  }

  public static string PrintBakeryMenu()
  {

    string breads = "Bread options: ";
    for (int i = 0; i < bread.Count; i++)
    {
      if (i == bread.Count - 1)
      {
        breads += " " + bread[i].Name;
      }
      else
      {
        breads += ", " + bread[i].Name;
      }
    }
    string pastries = "Pastry options: ";
    for (int i = 0; i < bread.Count; i++)
    {
      if (i == pastry.Count - 1)
      {
        pastries += " " + bread[i].Name;
      }
      else
      {
        pastries += ", " + bread[i].Name;
      }
    }
    string output = "\n" + breads + "\n " + pastries;
    return output;
  }
  }
}
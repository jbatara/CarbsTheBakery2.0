using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Models
{

  public class Bakery

  {

    private static int lastTransaction = 1;
    static List<Transaction> Transactions = new List<Transaction>();

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



    // public static void Main()
    // {
    //   Transaction t1 = CreateTransaction();
    //   t1.AddItem(wheat);
    //   t1.AddItem(rye);
    //   t1.AddItem(french);
    //   t1.AddItem(doughnut);
    //   t1.AddItem(seasonalFruitTart);
    //   t1.AddItem(doughnut);
    //   t1.AddItem(seasonalFruitTart);
    //   Transactions.Add(t1);
    //   POSMainMenu();
    // }

    // public static void POSMainMenu()
    // {
    //   Console.WriteLine("░░░░░░░░░░" + "Main Menu" + "░░░░░░░░░░");
    //   Console.WriteLine("| Start new transaction (s) | View old transactions (vo) | Edit old transactions (eo)|");

    //   string userInput = Console.ReadLine().ToLower();

    //   if (userInput == "s")
    //   {
    //     POSNewTransaction(0);
    //   }
    //   else if (userInput == "vo")
    //   {
    //     POSOldTransactions();
    //   }
    //   else if (userInput == "eo")
    //   {
    //     POSOldTransactions();
    //     Console.WriteLine("What transaction ID would you like to edit?");
    //     string userID = Console.ReadLine();
    //     int result;
    //    bool success = Int32.TryParse(userID, out result);
    //     if (success)
    //     {
    //       POSEditTransaction(result);
    //     }
    //     else
    //     {
    //       Console.WriteLine(userID + " is not a valid ID input. Going back to the main menu.");
    //       POSMainMenu();
    //     }
    //   }
    //   else
    //   {
    //     Console.WriteLine("That's an invalid input.");
    //     POSMainMenu();
    //   }
    // }

    // public static void POSNewTransaction(int code)
    // {
    //   //if code 0, new transaction. if code 1, then go back to the transaction menu again.
    //   if (code == 0)
    //   {
    //     Console.WriteLine("░░░░░░░░░░" + "New Transaction" + "░░░░░░░░░░");
    //     Transaction newTransaction = CreateTransaction();
    //     Transactions.Add(newTransaction);
    //     Console.WriteLine(newTransaction.PrintTransaction());
    //   }
    //   POSEditTransaction(Transactions[Transactions.Count - 1].ID);
    // }
    // public static void POSOldTransactions()
    // {
    //   Console.WriteLine("░░░░░░░░░░" + "Previous Transactions" + "░░░░░░░░░░");
    //   foreach (Transaction t in Transactions)
    //   {
    //     Console.WriteLine(t.PrintTransaction());
    //   }
    //   Console.WriteLine("| Start new transaction (s) | Edit old transactions (eo)| Main Menu (m)");
    //   string userInput = Console.ReadLine().ToLower();
    //   if (userInput == "s")
    //   {
    //     POSNewTransaction(0);
    //   }
    //   else if (userInput == "eo")
    //   {
    //     Console.WriteLine("What transaction ID would you like to edit?");
    //     string userID = Console.ReadLine();
    //     int result;
    //     bool success = Int32.TryParse(userID, out result);
    //     if (success)
    //     {
    //       POSEditTransaction(result);
    //     }
    //     else
    //     {
    //       Console.WriteLine(userID + " is not a valid ID input. Going back to the main menu.");
    //       POSMainMenu();
    //     }
    //   }
    //   else if (userInput == "m")
    //   {
    //     POSMainMenu();

    //   }
    //   else
    //   {
    //     Console.WriteLine("That's an invalid input. Return to Main Menu.");
    //     POSMainMenu();
    //   }

    // }

    // public static void POSEditTransaction(int id)
    // {
    //   if (Transactions.Count >= id && id > 0)
    //   {
    //     Transaction transaction = Transactions[id - 1];
    //     Console.WriteLine("░░░░░░░░░░" + "Edit Transactions" + "░░░░░░░░░░");
    //     Console.WriteLine(transaction.PrintTransaction());
    //     Console.WriteLine("| Add an item (A) | Subtract Item (S) | See Other Transactions(T) | Main Menu(M) |");
    //     string userInput = Console.ReadLine().ToLower();
    //     if (userInput == "a")
    //     {
    //       Console.WriteLine("Input name of item to add.");
    //       Console.WriteLine(PrintBakeryMenu());
    //       string userItemName = Console.ReadLine();
    //       List<Bread> breadSearch = bread.Where(b => b.Name == userItemName).ToList();
    //       List<Pastry> pastrySearch = pastry.Where(b => b.Name == userItemName).ToList();
    //       if (breadSearch.Count > 0)
    //       {
    //         transaction.AddItem(breadSearch[0]);
    //         POSEditTransaction(id);
    //       }
    //       else if (pastrySearch.Count > 0)
    //       {
    //         transaction.AddItem(pastrySearch[0]);
    //         POSEditTransaction(id);
    //       }
    //       else
    //       {
    //         Console.WriteLine(userItemName + " is not a valid Item name. The following items are valid entries:");
    //         PrintBakeryMenu();
    //         POSEditTransaction(id);
    //       }
    //     }
    //     else if (userInput == "s")
    //     {
    //       if (Transactions.Count == 0)
    //       {
    //         Console.WriteLine("There is nothing to subtract. Please add an item before trying to subtract an item from the transaction.");
    //         POSEditTransaction(id);
    //       }
    //       else
    //       {
    //         Console.WriteLine("Input name of item to subtract.");
    //         string userItemName = Console.ReadLine();
    //         List<Merchandise> transactionSearch = transaction.Items.Where(b => b.Name == userItemName).ToList();
    //         if (transactionSearch.Count > 0)
    //         {
    //           transaction.SubtractItem(transactionSearch[0]);
    //           POSEditTransaction(id);
    //         }
    //         else
    //         {
    //           Console.WriteLine(userItemName + " is not a valid Item name. The following items are valid entries:");
    //           Console.WriteLine(PrintBakeryMenu());
    //           POSEditTransaction(id);
    //         }
    //       }
    //     }
    //     else if (userInput == "t")
    //     {
    //       POSOldTransactions();
    //     }
    //     else if (userInput == "m")
    //     {
    //       POSMainMenu();
    //     }
    //   }
    //   else
    //   {
    //     Console.WriteLine("An id of " + id + " is an invalid Input. Going back to the Main Menu.");
    //     POSMainMenu();
    //   }
    // }

    // public static Transaction CreateTransaction(int vendorID)
    // {
    //   Transaction o = new Transaction(vendorID);
    //   return o;
    // }

    // public static string PrintBakeryMenu()
    // {

    //   string breads = "Bread options: ";
    //   for (int i = 0; i < bread.Count; i++)
    //   {
    //     if (i == bread.Count - 1 || i == 0)
    //     {
    //       breads += " " + bread[i].Name;
    //     }
    //     else
    //     {
    //       breads += ", " + bread[i].Name;
    //     }
    //   }
    //   string pastries = "Pastry options: ";
    //   for (int i = 0; i < pastry.Count; i++)
    //   {
    //     if (i == pastry.Count - 1 || i == 0)
    //     {
    //       pastries += " " + pastry[i].Name;
    //     }
    //     else
    //     {
    //       pastries += ", " + pastry[i].Name;
    //     }
    //   }
    //   string output = "\n" + breads + "\n " + pastries;
    //   return output;
    // }
  }
}

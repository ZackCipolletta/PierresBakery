using System;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("********************************************************************");
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine(
        "Today we have a sale on Bread and Pastries; Bread loaves are $5 each and for every 2 loaves yiou buy, get 1 freee. Pastries are $2 and for every 3 pastries you buy get 1 free."
      );
      Console.WriteLine(
        "Please type the number of loaves of bread you would like to buy (using numbers only)."
      );
      string numberOfLoaves = Console.ReadLine();
      int loaves = int.Parse(numberOfLoaves);
      BreadLoaves breadOrder = new BreadLoaves(loaves);
      Console.WriteLine($"You have ordered {breadOrder.CustomerOrder} loaves of bread.  The total for your bread order is: ${breadOrder.TotalPrice()}.");
      Console.WriteLine(
        "Please type the number of pastries you would like to buy (using numbers only)."
      );
      string numberOfPastries = Console.ReadLine();
      int pastries = int.Parse(numberOfPastries);
      Pastries pastriesOrder = new Pastries(pastries);
      Console.WriteLine($"You have ordered {pastriesOrder.CustomerPastriesOrder} pastries. The total cost of your pastry order is: ${pastriesOrder.TotalPrice()}.");
      Console.WriteLine($"You have ordered {loaves} loaves of bread and {pastries} pastries.  Your order total is: ${breadOrder.TotalPrice() + pastriesOrder.TotalPrice()}.");
      Console.WriteLine("======================================================================");
      Console.WriteLine("Would you like to edit your order? If so type 'yes', otherwise type anything else.");
      string orderEdit = Console.ReadLine();
      if (orderEdit == "yes" || orderEdit == "Yes")
      {
        Console.WriteLine("Would you like to change the number of bread loaves you have ordered? if so type 'yes'.");
        string loavesEdit = Console.ReadLine();
        if (loavesEdit == "yes" || loavesEdit == "Yes")
        {
          Console.WriteLine("How many more loaves of bread would you like to buy (using numbers only)?");
          int changeLoavesOrder = int.Parse(Console.ReadLine());
          breadOrder.CustomerOrder = changeLoavesOrder;
        }
        Console.WriteLine("Would you like to change the number of pastries you have ordered? if so type 'yes'.");
        string pastriesEdit = Console.ReadLine();
        if (pastriesEdit == "yes" || pastriesEdit == "Yes")
        {
          Console.WriteLine("How many pastries would you like to order?");
          string changePastriesOrder = Console.ReadLine();
          pastriesOrder.CustomerPastriesOrder = int.Parse(changePastriesOrder);
        }
        Console.WriteLine($"You have ordered {breadOrder.CustomerOrder} loaves of bread and {pastriesOrder.CustomerPastriesOrder} pastries.  Your order total is: ${breadOrder.TotalPrice() + pastriesOrder.TotalPrice()}.");
      }
      Console.WriteLine("If you would like to start a new order please type 'yes'.");
      string startOver = Console.ReadLine();
      if (startOver == "yes" || startOver == "Yes")
      {
        Main();
      }
      else
      {
        Console.WriteLine($"Final total: ${breadOrder.TotalPrice() + pastriesOrder.TotalPrice()}");
      }
    }

  }

}
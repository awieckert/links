﻿using System;
using System.Linq;
using System.Collections.Generic;

  public class GroupedMillionaires {
    public string Bank { get; set; }

    public IEnumerable<string> Millionaires { get; set; }

  }
  public class Bank
{
    public string Symbol { get; set; }
    public string Name { get; set; }
}
// Define a customer
public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}
public class Program
{
    public static void Main() {

      List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

      IEnumerable<string> LFruits = (from fruit in fruits
        where fruit.IndexOf("L") == 0
        select fruit).ToList();

      foreach (string item in LFruits)
      {
          Console.WriteLine($"All Fruits that begin with L: {item}");
      }

      // Which of the following numbers are multiples of 4 or 6
      List<int> numbers = new List<int>()
      {
          15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      };

      IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 && n % 6 == 0);
      Console.WriteLine($"These numbers are multiple of 4 and 6: {String.Join(", ", fourSixMultiples)}");


      // Order these student names alphabetically, in descending order (Z to A)
      List<string> names = new List<string>()
      {
          "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
          "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
          "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
          "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
          "Francisco", "Tre"
      };

      List<string> descend = names.OrderByDescending(name => name).ToList();
      Console.WriteLine($"{String.Join(", ", descend)}");

      // Build a collection of these numbers sorted in ascending order
      List<int> numbersList = new List<int>()
      {
          15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      };

      IEnumerable<int> lowestFirst = numbersList.OrderBy(n => n);
      Console.WriteLine($"Lowest Numbers First {String.Join(", ", lowestFirst)}");

    // Output how many numbers are in this list
    List<int> numbers3 = new List<int>()
    {
        15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
    };

      Console.WriteLine($"There are this many numbers: {numbers3.Count()}");



      // How much money have we made?
      List<double> purchases = new List<double>()
      {
          2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
      };

      Console.WriteLine($"We Made this much monies!: {purchases.Sum().ToString("C")}");

      // What is our most expensive product?
      List<double> prices = new List<double>()
      {
          879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
      };

      Console.WriteLine($"The Highest Priced Item is: {prices.Max().ToString("C")}");

      /*
      Store each number in the following List until a perfect square
      is detected.

      Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
      */
      List<int> wheresSquaredo = new List<int>()
      {
          66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
      };

      IEnumerable<int> theNonSquares = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 != 0);
      Console.WriteLine($"All the not squares {String.Join(", ", theNonSquares)}");

      /*
          Given the same customer set, display how many millionaires per bank.
          Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

          Example Output:
          WF 2
          BOA 1
          FTB 1
          CITI 1
      */
      List<Customer> customers = new List<Customer>() {
        new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
        new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
        new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
        new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
        new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
        new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
        new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
        new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
        new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
        new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
      };

      var groupedByBank = customers.Where(c => c.Balance >= 1000000).GroupBy(
        p => p.Bank,
        p => p.Name,
        (bank, millionaires) => new GroupedMillionaires()
        {
          Bank = bank,
          Millionaires = millionaires
        }
      ).ToList();

      foreach (GroupedMillionaires item in groupedByBank)
      {
          Console.WriteLine($"{item.Bank}: {item.Millionaires.Count()}");
      }

        // Create some banks and store in a List
        List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

        // Create some customers and store in a List
        List<Customer> customers7 = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

        /*
    TASK:
    As in the previous exercise, you're going to output the millionaires,
    but you will also display the full name of the bank. You also need
    to sort the millionaires' names, ascending by their LAST name.

    Example output:
        Tina Fey at Citibank
        Joe Landy at Wells Fargo
        Sarah Ng at First Tennessee
        Les Paul at Wells Fargo
        Peg Vale at Bank of America
*/

        List<Customer> millionaireReport = customers7.Where(n => n.Balance >= 1000000).Select(c => new Customer(){
          Name = c.Name,
          Bank = banks.Find(b => c.Bank == b.Symbol).Name
        }).ToList();

        foreach (Customer customer in millionaireReport)
        {
          customer.Name = String.Join(" ", customer.Name.Split(' ').Reverse());
        }

        List<Customer> orderedMillionaires = millionaireReport.OrderBy(n => n.Name).ToList();

        foreach (Customer customer in orderedMillionaires)
        {
          customer.Name = String.Join(" ", customer.Name.Split(' ').Reverse());
        }

        foreach (Customer customer in orderedMillionaires)
        {
            Console.WriteLine($"{customer.Name} at {customer.Bank}");
        }



      // Main ends here
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

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
      // Main ends here
    }
}

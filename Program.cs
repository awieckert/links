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
    }
}

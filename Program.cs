using System;

namespace ANewWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      //variables//
      int min = 0;
      int max = 100;
      int answer = 50;
      var input = "";
      var guess = "";
      int lower = 0;
      int attempts = 1;

      Console.WriteLine($"Pick a number between 1 and 100:");
      Console.WriteLine($"is the number {(min + max) / 2}? If not, type 'higher','lower', or 'yes'.");


      //while loop
      while (input != "yes")
      {

        guess = Console.ReadLine();
        if (guess.ToLower() == "higher")
        {
          min = answer + 1;
          answer = (min + max) / 2;
          Console.WriteLine($"is your number {answer}");
          Console.WriteLine("Type: 'yes', 'higher', or 'lower'.");
          attempts++;
        }
        if (guess.ToLower() == "lower")
        {
          max = answer - 1;
          answer = (min + max) / 2;
          Console.WriteLine($"is your number {answer}");
          Console.WriteLine("Type: 'yes', 'higher', or 'lower' to move forward");
          attempts++;
        }
      }
      Console.WriteLine("Got it!");
      Console.WriteLine($"It only took me {attempts}");
    }
  }
}
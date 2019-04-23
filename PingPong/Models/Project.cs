using System;

namespace PingPong
{
  public class Project
  {
      public static void Main() {
        Console.WriteLine("Please enter a number");
        string enteredNumber = Console.ReadLine();
        int enteredInt = int.Parse(enteredNumber);
        Game newGame = new Game ();
        newGame.replaceNumbersWithPingPong(enteredInt);
      }

  }
}

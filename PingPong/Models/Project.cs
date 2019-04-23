using System;
using System.Collections.Generic;

namespace PingPong
{
  public class Project
  {
      public static void Main() {
        Console.WriteLine("Please enter a number");
        string enteredNumber = Console.ReadLine();
        int enteredInt = int.Parse(enteredNumber);
        Game newGame = new Game();
        // List<int> numbers = new List<int>();
        // for(int i =1; i<= enteredInt; i++ ){
        //   i = newGame.replaceNumbersWithPingPong(i);
        //   numbers.Add(i);
        // }
        newGame.replaceNumbersWithPingPong(15);
      }
  }
}

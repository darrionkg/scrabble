using System;
using System.Collections.Generic;

namespace ScrabbleStuff

{
  public class MainClass
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to find its Scrabble score");
      string userInput = Console.ReadLine();
      Words newWord = new Words(userInput);
      char[] charArray = newWord.MakeArray();
      int totalScore = newWord.Compare(charArray);
      Console.WriteLine("Scrabble score for " + userInput + " is " + totalScore);
    }
  }
}

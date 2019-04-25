using System.Collections.Generic;

namespace ScrabbleStuff

{
  public class Words
  {
    private string _word;
    private static Dictionary<char, int> _letterPoints = new Dictionary<char, int> ()
    {
      {'a', 1}, {'e', 1}, {'i', 1}, {'o', 1}, {'u', 1}, {'l', 1}, {
      'n', 1}, {'r', 1}, {'s', 1}, {'t', 1}, {'d', 2}, {'g', 2}, {'b', 3}, {'c', 3}, {'m', 3}, {'p', 3}, {'f', 4}, {'h', 4}, {'v', 4}, {'w', 4}, {'y', 4}, {'k', 5}, {'j', 8}, {'x', 8}, {'q', 10}, {'z', 10}
    };

    public Words(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }

    public int GetValues(char letter)
    {
      return _letterPoints[letter];
    }

    public void SetWord(string newWord)
    {
      _word = newWord;
    }

    public char[] MakeArray()
    {
      _word = _word.ToLower();
      char[] charArr = _word.ToCharArray();
      return charArr;
    }

    public int Compare(char[] charArray)
    {
      int totalScore = 0;
      for(int i = 0; i < charArray.Length; i++)
      {
        int tempScore = GetValues(charArray[i]);
        totalScore += tempScore;
      }
      return totalScore;
    }
  }
  
}

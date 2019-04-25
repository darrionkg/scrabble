namespace ScrabbleStuff
{
  public class Words
  {
    private string _word;

    public Words(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string newWord)
    {
      _word = newWord;
    }
  }
}

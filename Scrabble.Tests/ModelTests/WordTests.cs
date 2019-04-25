using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleStuff;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordsTest
  {
    [TestMethod]
    public void SetProperty_StoresWords_True()
    {
      Words testWords = new Words("word");
      Assert.AreEqual(typeof(Words), testWords.GetType());
    }
  }
}

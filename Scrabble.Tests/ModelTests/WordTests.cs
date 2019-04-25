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

    // [TestMethod]
    // public void MakeArray_StringReturnsLetterArray_True()
    // {
    //   Words testWords = new Words("word");
    //   Assert.AreEqual('w', testWords.MakeArray());
    // }

    [TestMethod]
    public void WordValue_FindLetterValue_Int()
    {
      Words testWords = new Words("word");
      int value = testWords.GetValues("w");
      Assert.AreEqual(4, value);
    }

  }
}

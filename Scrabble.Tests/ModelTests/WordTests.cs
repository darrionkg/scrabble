using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleStuff;
using System;
using System.Collections.Generic;

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

    [TestMethod]
    public void MakeArray_StringReturnsLetterArray_True()
    {
      char[] testArray = {'w', 'o', 'r', 'd'};
      Words testWords = new Words("word");
      CollectionAssert.AreEqual(testArray, testWords.MakeArray());
    }

    [TestMethod]
    public void WordValue_FindLetterValue_Int()
    {
      Words testWords = new Words("word");
      int value = testWords.GetValues('w');
      Assert.AreEqual(4, value);
    }

    [TestMethod]
    public void Compare_CompareWordToDictionary_Int()
    {
      Words testWords = new Words("word");
      char[] charArray = testWords.MakeArray();
      int totalScore = testWords.Compare(charArray);
      Assert.AreEqual(8, totalScore);
    }
  }
}

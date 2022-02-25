using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers.Models;
using System;
using System.Collections.Generic;

namespace Numbers.Tests
{
  [TestClass]
  public class NumbersTests
  {
    [TestMethod]
    public void NumberTranslator_Translates3toThree_Three()
    {
      Assert.AreEqual("three", Translate.NumberTranslator(3));
    }

    [TestMethod]
    public void NumberTranslator_TranslatesSeventeen_SevenTeen()
    {
      Assert.AreEqual("seventeen", Translate.NumberTranslator(17));
    }

    [TestMethod]
    public void NumberTranslator_Translates88ToEightyEight_EightyEight()
    {
      Assert.AreEqual("eighty eight", Translate.NumberTranslator(88));
    }
    [TestMethod]
    public void NumberTranslator_Translates588ToFiveHundredEightyEight_FiveHundredEightyEight()
    {
      Assert.AreEqual("five hundred eighty eight", Translate.NumberTranslator(588));
    }

    [TestMethod]
    public void NumberTranslator_Translates123456789ToTextVersion_LargeString()
    {
      Assert.AreEqual("one hundred twenty three million, four hundred fifty six thousand, seven hundred eighty nine", Translate.NumberTranslator(123456789));
    }
  }
}
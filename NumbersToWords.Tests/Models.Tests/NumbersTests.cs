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
  }
}
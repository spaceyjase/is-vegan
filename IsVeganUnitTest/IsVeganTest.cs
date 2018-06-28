using System;
using IsVegan.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsVeganUnitTest
{
  [TestClass]
  public class IsVeganTest
  {
    readonly IsVegan.Models.IsVegan isVegan = new IsVegan.Models.IsVegan();
    [TestMethod]
    public void TrueForEmptyString()
    {
      Assert.IsTrue(isVegan.IsVeganIngredient(string.Empty));
    }
  }
}

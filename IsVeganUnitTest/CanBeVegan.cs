using System;
using System.Linq;
using IsVegan.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsVeganUnitTest
{
  [TestClass]
  public class CanBeVeganUnitTest
  {
    private readonly IsVegan.Models.CanBeVegan canBeVegan = new IsVegan.Models.CanBeVegan();

    [TestMethod]
    public void ShouldBeTrueForEmptyString()
    {
      Assert.IsTrue(canBeVegan.IsFlaggedIngredient(""));
    }

    [TestMethod]
    public void ShouldBeFlaggedIngredient()
    {
      Assert.IsTrue(canBeVegan.IsFlaggedIngredient("biotin"));
    }

    [TestMethod]
    public void ShouldNotBeFlaggedIngredient()
    {
      Assert.IsFalse(canBeVegan.IsFlaggedIngredient("soy"));
    }

    [TestMethod]
    public void ShouldNotContainFlaggedIngredients()
    {
      Assert.IsTrue(canBeVegan.ContainsFlaggedIngredients(new string[] { "soy", "cacao butter" }).Length == 0);
    }

    [TestMethod]
    public void ShouldContainFlaggedIngredients()
    {
      Assert.IsTrue(canBeVegan.ContainsFlaggedIngredients(new string[] { "biotin", "glycine", "soy" })
        .SequenceEqual(new string[] { "biotin", "glycine" }));
    }
  }
}

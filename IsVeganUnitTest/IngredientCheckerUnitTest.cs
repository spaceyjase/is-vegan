using System;
using System.Linq;
using IsVegan.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsVeganUnitTest
{
  [TestClass]
  public class IngredientCheckerUnitTest
  {
    private readonly IngredientChecker checkIngredients = new IngredientChecker();

    [TestMethod]
    public void ShouldContainFlaggedIngredientsButNoNonVeganIngredients()
    {
      var result = checkIngredients.CheckIngredients(new string[]{
        "biotin",
        "glycine",
        "soy",
        "garlic"
      });
      Assert.IsTrue(result.NonVegan.Length == 0 && result.Flagged.SequenceEqual(new string[] { "biotin", "glycine" }));
    }

    [TestMethod]
    public void ShouldNotContainFlaggedIngredientsButNoNonVeganIngredients()
    {
      var result = checkIngredients.CheckIngredients(new string[]{
        "beef",
        "pork",
        "soy",
        "garlic"
      });
      Assert.IsTrue(result.NonVegan.SequenceEqual(new string[] { "beef", "pork" }) && result.Flagged.Length == 0);
    }

    [TestMethod]
    public void ShouldContainFlaggedAndNonVeganIngredients()
    {
      var result = checkIngredients.CheckIngredients(new string[]{
        "beef",
        "pork",
        "glycine",
        "biotin",
        "soy",
        "garlic"
      });
      Assert.IsTrue(
        result.NonVegan.SequenceEqual(new string[] { "beef", "pork" }) &&
        result.Flagged.SequenceEqual(new string[] { "glycine", "biotin" })
      );
    }
  }
}

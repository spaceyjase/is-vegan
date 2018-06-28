using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsVeganUnitTest
{
  [TestClass]
  public class IsVeganTest
  {
    private readonly IsVegan.Models.IsVegan isVegan = new IsVegan.Models.IsVegan();

    [TestMethod]
    public void TrueForEmptyString()
    {
      Assert.IsTrue(isVegan.IsVeganIngredient(string.Empty));
    }

    [TestMethod]
    public void ShouldBeVeganIngredient()
    {
      Assert.IsTrue(isVegan.IsVeganIngredient("soy"));
    }

    [TestMethod]
    public void ShouldNotBeVeganIngredient()
    {
      Assert.IsFalse(isVegan.IsVeganIngredient("milk"));
    }

    [TestMethod]
    public void ShouldNotBeVeganIngredientList()
    {
      Assert.IsFalse(isVegan.IsVeganIngredientList(new string[]{ "aspid", "albumin" }));
    }

    [TestMethod]
    public void ShouldBeVeganIngredientList()
    {
      Assert.IsTrue(isVegan.IsVeganIngredientList(new string[]{ "soy", "cacao butter" }));
    }

    [TestMethod]
    public void ShouldNotContainNonVeganIngredientList()
    {
      Assert.IsTrue(isVegan.ContainsNonVeganIngredients(new string[] { "soy", "cacao butter" }).Length == 0);
    }

    [TestMethod]
    public void ShouldContainNonVeganIngredientList()
    {
      Assert.IsTrue(isVegan.ContainsNonVeganIngredients(new string[] { "aspic", "albumin", "soy" })
        .SequenceEqual(new string[] { "aspic", "albumin" }));
    }
  }
}

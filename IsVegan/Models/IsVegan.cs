using IsVegan.Data;
using System.Collections.Generic;
using System.Linq;

namespace IsVegan.Models
{
  public class IsVegan
  {
    private readonly List<string> nonVeganData;

    /// <summary>
    /// Initializes a new instance of the <see cref="NonVegan"/> class.
    /// </summary>
    public IsVegan()
    {
      nonVeganData = new List<string>(DataUtility.LoadDataFromResource("IsVegan.Resources.nonvegan.json"));
    }

    /// <summary>
    /// Determines whether [is vegan ingredient] [the specified ingredient to check].
    /// </summary>
    /// <param name="ingredientToCheck">The ingredient to check.</param>
    /// <returns>
    ///   <c>true</c> if [is vegan ingredient] [the specified ingredient to check]; otherwise, <c>false</c>.
    /// </returns>
    public bool IsVeganIngredient(string ingredientToCheck)
    {
      bool result = false;
      if (string.IsNullOrEmpty(ingredientToCheck))
      { // true if empty
        result = true;
      }
      else
      { // check the ingredient
        string formattedIngredient = ingredientToCheck.Trim().ToLowerInvariant();
        result = !nonVeganData.Contains(formattedIngredient);
      }
      return result;
    }

    /// <summary>
    /// Determines whether [is vegan ingredient list] [the specified ingredients to check].
    /// </summary>
    /// <param name="ingredientsToCheck">The ingredients to check.</param>
    /// <returns>
    ///   <c>true</c> if [is vegan ingredient list] [the specified ingredients to check]; otherwise, <c>false</c>.
    /// </returns>
    public bool IsVeganIngredientList(string[] ingredientsToCheck)
    {
      return !ingredientsToCheck.Any(ingredient => !IsVeganIngredient(ingredient));
    }

    /// <summary>
    /// Determines whether [contains non vegan ingredients] [the specified ingredients to check].
    /// </summary>
    /// <param name="ingredientsToCheck">The ingredients to check.</param>
    /// <returns>Array of non-Vegan ingredients.</returns>
    public string[] ContainsNonVeganIngredients(string[] ingredientsToCheck)
    {
      return ingredientsToCheck.Where(ingredient => !IsVeganIngredient(ingredient)).ToArray();
    }
  }
}

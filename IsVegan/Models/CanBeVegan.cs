using IsVegan.Data;
using System.Collections.Generic;
using System.Linq;

namespace IsVegan.Models
{
  public class CanBeVegan
  {
    private readonly List<string> flaggedList;

    /// <summary>
    /// Initializes a new instance of the <see cref="CanBeVegan"/> class.
    /// </summary>
    public CanBeVegan()
    {
      flaggedList = new List<string>(DataUtility.LoadDataFromResource("IsVegan.Resources.canbevegan.json"));
    }

    /// <summary>
    /// Determines whether [is flagged ingredient] [the specified ingredient to check].
    /// </summary>
    /// <param name="ingredientToCheck">The ingredient to check.</param>
    /// <returns>
    ///   <c>true</c> if [is flagged ingredient] [the specified ingredient to check]; otherwise, <c>false</c>.
    /// </returns>
    public bool IsFlaggedIngredient(string ingredientToCheck)
    {
      bool result = false;
      if (string.IsNullOrEmpty(ingredientToCheck))
      { // true if empty
        result = true;
      }
      else
      {
        string formattedIngredient = ingredientToCheck.Trim().ToLowerInvariant();
        result = flaggedList.Contains(formattedIngredient);
      }
      return result;
    }

    /// <summary>
    /// Determines whether [contains flagged ingredient] [the specified ingredients to check].
    /// </summary>
    /// <param name="ingredientsToCheck">The ingredients to check.</param>
    /// <returns>Array of flagged ingredients.</returns>
    public string[] ContainsFlaggedIngredients(string[] ingredientsToCheck)
    {
      return ingredientsToCheck.Where(ingredient => IsFlaggedIngredient(ingredient)).ToArray();
    }
  }
}

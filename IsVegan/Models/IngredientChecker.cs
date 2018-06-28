using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsVegan.Models
{
  public partial class IngredientChecker
  {
    private CanBeVegan canBeVegan = new CanBeVegan();
    private IsVegan isVegan = new IsVegan();

    public FilteredIngredients CheckIngredients(string[] ingredientsToCheck)
    {
      return new FilteredIngredients(
        isVegan.ContainsNonVeganIngredients(ingredientsToCheck),
        canBeVegan.ContainsFlaggedIngredients(ingredientsToCheck)
      );
    }
  }
}

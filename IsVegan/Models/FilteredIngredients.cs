namespace IsVegan.Models
{
  public partial class IngredientChecker
  {
    public class FilteredIngredients
    {
      public string[] NonVegan { get; private set; }
      public string[] Flagged { get; private set; }
      public FilteredIngredients(string[] nonVegan, string[] flagged)
      {
        NonVegan = nonVegan;
        Flagged = flagged;
      }
    }
  }
}

using System.Collections.Generic;

namespace IsVegan.Data
{
  public class CanBeVegan
  {
    private List<string> data;

    /// <summary>
    /// Initializes a new instance of the <see cref="CanBeVegan"/> class.
    /// </summary>
    public CanBeVegan()
    {
      data = new List<string>(DataUtility.LoadDataFromResource("IsVegan.Resources.canbevegan.json"));
    }
  }
}

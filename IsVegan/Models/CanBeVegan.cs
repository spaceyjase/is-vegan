using IsVegan.Data;
using System.Collections.Generic;

namespace IsVegan.Models
{
  public class CanBeVegan
  {
    private readonly List<string> data;

    /// <summary>
    /// Initializes a new instance of the <see cref="CanBeVegan"/> class.
    /// </summary>
    public CanBeVegan()
    {
      data = new List<string>(DataUtility.LoadDataFromResource("IsVegan.Resources.canbevegan.json"));
    }
  }
}

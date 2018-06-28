using IsVegan.Data;
using System.Collections.Generic;

namespace IsVegan.Models
{
  public class NonVegan
  {
    private readonly List<string> data;

    /// <summary>
    /// Initializes a new instance of the <see cref="NonVegan"/> class.
    /// </summary>
    public NonVegan()
    {
      data = new List<string>(DataUtility.LoadDataFromResource("IsVegan.Resources.nonvegan.json"));
    }
  }
}

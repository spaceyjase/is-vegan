using System.Collections.Generic;

namespace IsVegan.Data
{
  public class NonVegan
  {
    private List<string> data;

    /// <summary>
    /// Initializes a new instance of the <see cref="NonVegan"/> class.
    /// </summary>
    public NonVegan()
    {
      data = new List<string>(DataUtility.LoadDataFromResource("IsVegan.Resources.nonvegan.json"));
    }
  }
}

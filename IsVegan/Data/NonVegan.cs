using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
      var assembly = Assembly.GetExecutingAssembly();
      using (Stream stream = assembly.GetManifestResourceStream("IsVegan.Resources.nonvegan.json"))
      {
        using (StreamReader reader = new StreamReader(stream))
        {
          string json = reader.ReadToEnd();
          data = JsonConvert.DeserializeObject<List<string>>(json);
        }
      }
    }
  }
}

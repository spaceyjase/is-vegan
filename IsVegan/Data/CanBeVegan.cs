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
  public class CanBeVegan
  {
    private List<string> data;

    /// <summary>
    /// Initializes a new instance of the <see cref="CanBeVegan"/> class.
    /// </summary>
    public CanBeVegan()
    {
      var assembly = Assembly.GetExecutingAssembly();
      using (Stream stream = assembly.GetManifestResourceStream("IsVegan.Resources.canbevegan.json"))
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

using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace IsVegan.Data
{
  public static class DataUtility
  {
    public static string[] LoadDataFromResource(string resource)
    {
      string[] data = null;
      var assembly = Assembly.GetExecutingAssembly();
      using (Stream stream = assembly.GetManifestResourceStream(resource))
      {
        using (StreamReader reader = new StreamReader(stream))
        {
          string json = reader.ReadToEnd();
          data = JsonConvert.DeserializeObject<string[]>(json);
        }
      }
      return data;
    }
  }
}

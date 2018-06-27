using IsVegan.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsVegan
{
  class Program
  {
    static void Main(string[] args)
    {
      CanBeVegan canBeVegan = new CanBeVegan();
      NonVegan nonVegan = new NonVegan();
    }
  }
}

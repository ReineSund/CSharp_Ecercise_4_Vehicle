using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exercise_4_Vehicle
{
  public class Motorcycle : Vehicle // Inherits from Vehicle class
  {
    public void PutHelmetOn()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Helmet suits well,...");
      Console.WriteLine("Nice ang safe!\n");
    }
  }
}


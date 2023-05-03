using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exercise_4_Vehicle
{
  public class eCar : Car // Inherits from Car class
  {

    public override string ToString()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      return Color + " " + Manufacturer;
    }

    public void Drive()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("White Nissan ARIYA goes ssshhhhhhh!");
    }
  }
}

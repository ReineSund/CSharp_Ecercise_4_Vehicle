using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exercise_4_Vehicle
{
  public class Vehicle // base class
  {
    // Properties of the vehicle
    public string Manufacturer { get; set; }
    public string Color { get; set; }
    public int GasLevel { get; set; }

    public void Drive() // Drive method for the vehicle except eCar that has its own drive method
    {
      string key = " ";

      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(Color + " " + Manufacturer);
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Motor is running, VROOOOM!");
      Console.ForegroundColor = ConsoleColor.White;

      while (GasLevel > 0)
      {
        Console.WriteLine("Gas level: " + GasLevel);
        Console.WriteLine("Continue driving? Yes (y) No (n) (Enter) ");
        key = Console.ReadLine();

        if (key == ("Y") | key == ("y"))
        {
          GasLevel--;
        }
        else if (key == ("N") | key == ("n"))
        {
          break;
        }
        if (GasLevel == 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Run out of gas!");
          break;
        }        
      }
    }
  }
}

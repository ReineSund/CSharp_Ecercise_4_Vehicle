using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exercise_4_Vehicle
{
  public class Car : Vehicle // Inherits from Vehicle class
  {
    public void OpenRadio() {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Open car radio,...");
      Console.WriteLine("Jeee, rock'n roll!\n");
    }
    public void OpenWindow() {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("Car window is open,...");
      Console.WriteLine("Ahh,... fresh air!\n");
    }
  }
}
  




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Exercise_4_Vehicle;

namespace CSharp_Exercise_4_Vehicle
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Create and assign properties to the car*/
      Car car = new Car()
      {
        Manufacturer = "BMW",
        Color = "Red",
        GasLevel = 4
      };

      car.OpenRadio();
      car.OpenWindow();
      car.Drive();

      /*Create and assigns properties to the motorcycle*/
      //Motorcycle motorcycle = new Motorcycle()
      //{
      //  Manufacturer = "Harley Davidson",
      //  Color = "Black",
      //  GasLevel = 3
      //};

      //motorcycle.PutHelmetOn();
      //motorcycle.Drive();


      /*Create and use an electric car*/
      //eCar ecar = new eCar()
      //{
      //  Manufacturer = "Nissan ARIYA",
      //  Color = "White",
      //  GasLevel = 4
      //};

      ////Console.WriteLine(ecar.ToString());
      //ecar.Drive();

    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVehicles.Cars;

public class Porsche : IVehicle, ICar
{
    public int FuelCapacity { get; set; }
    public string Color { get; set; }
    public int PassengerCapacity { get; set; }
    public int FuelLevel { get; set; }

    public int MPG { get; set; }

    public void Brake()
    {
        Console.WriteLine("Braking");
    }

    public void Drive()
    {
        Console.WriteLine("Driving");
    }
}

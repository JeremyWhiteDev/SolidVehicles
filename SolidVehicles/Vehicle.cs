using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVehicles;

public interface IVehicle
{
     int FuelCapacity { get; set; }
     string Color { get; set; }
     int PassengerCapacity { get; set; }
     int FuelLevel { get; set; }

    int MPG { get; set; }

     void Refuel()
    {
        Console.WriteLine("Refueling");
        int neededFuel = FuelCapacity - FuelLevel;
        FuelLevel = FuelCapacity;
        Console.WriteLine($"You just put {neededFuel} gallons of gas in your vehicle. ");
    }

    void ClassesDoNotNeedToImplementThisMethod()
    {
        Console.WriteLine("Yeehaw");
    }

//If there is a method that doesn't have a body (or default implementation) then classes that use that interface MUST have an implementation.

    //int ClassesNeedToImplementThisMethod();
}

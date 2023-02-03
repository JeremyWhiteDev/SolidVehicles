using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVehicles.WaterCraft;

public class BoatyMcBoatFace : IWatercraft, IVehicle
{
    public int FuelCapacity { get; set; }
    public string Color { get; set; }
    public int PassengerCapacity { get; set; }
    public int FuelLevel { get; set; }

    public int MPG { get; set; }

    public string UniqueProp { get; set; }

    public void Dock()
    {
        Console.WriteLine("Docking");
    }

    public void Sail()
    {
        Console.WriteLine("Sailing");
    }


    //There is no implementation for HelloMsg, so the default implementation will be called.

}

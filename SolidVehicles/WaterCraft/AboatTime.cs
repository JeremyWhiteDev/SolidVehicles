using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVehicles.WaterCraft;

public class AboatTime : IVehicle, IWatercraft
{
    public int FuelCapacity { get; set; }
    public string Color { get; set; }
    public int PassengerCapacity { get; set; }
    public int FuelLevel { get; set; }

    public int MPG { get; set; }
    public bool Anchor { get; set; }

    public void Dock()
    {
        Console.WriteLine("Docking");
    }

    public void Sail()
    {
        Console.WriteLine("Docking");
    }

    //this method will be called instead of the default implementation
    public  void HelloMsg()
    {
        Console.WriteLine("WOOT");
    }

}

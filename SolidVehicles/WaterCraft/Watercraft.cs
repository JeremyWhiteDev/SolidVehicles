using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVehicles.WaterCraft;

public interface IWatercraft
{

    public void Sail()
    {
        Console.WriteLine("Sailing");
    }
    public void Dock()
    {
        Console.WriteLine("Docking");
    }
}

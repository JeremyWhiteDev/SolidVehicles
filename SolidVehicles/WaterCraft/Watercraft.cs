using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVehicles.WaterCraft;

public interface IWatercraft
{

    void Sail();
    void Dock();

    void HelloMsg()
    {
        Console.WriteLine("HELLO");
    }

   // void Trial();

}

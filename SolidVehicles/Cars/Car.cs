using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVehicles.Cars;

public interface ICar
{


    public void Drive()
    {
        Console.WriteLine("Driving");
    }
    public void Brake()
    {
        Console.WriteLine("Braking");
    }
}

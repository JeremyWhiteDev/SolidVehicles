﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVehicles.Cars
{
    internal class Porsche : IVehicle, ICar
    {
        public int FuelCapacity { get; set; }
        public string Color { get; set; }
        public int PassengerCapacity { get; set; }
        public int FuelLevel { get; set; }

        public int MPG { get; set; }
    }
}

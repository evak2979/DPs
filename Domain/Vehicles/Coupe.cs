using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Domain.Abstracts;
using DP.Domain.Enums;
using DP.Domain.Interfaces;

namespace DP.Domain.Vehicles
{
    public class Coupe : AbstractCar
    {
        public Coupe(IEngine engine) : base(engine)
        {
        }

        public Coupe(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}

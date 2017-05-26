using System;
using DP.Domain.Enums;
using DP.Domain.Interfaces;

namespace DP.Domain.Abstracts
{
    public abstract class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine) : base(engine)
        {
        }

        public AbstractCar(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }

        public override void Paint(VehicleColour colour)
        {
            Console.WriteLine("Painting car...");
        }
    }
}

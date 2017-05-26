using System;
using DP.Domain.Enums;
using DP.Domain.Interfaces;

namespace DP.Domain.Abstracts
{
    public abstract class AbstractVan : AbstractCar
    {
        public AbstractVan(IEngine engine) : base(engine)
        {
        }

        public AbstractVan(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }

        public override void Paint(VehicleColour colour)
        {
            Console.WriteLine("Painting van...");
        }
    }
}

using DP.Domain.Abstracts;
using DP.Domain.Enums;
using DP.Domain.Interfaces;

namespace DP.Domain.Vehicles
{
    public class PickUp : AbstractVan
    {
        public PickUp(IEngine engine) : base(engine)
        {
        }

        public PickUp(IEngine engine, VehicleColour colour) : base(engine, colour)
        {
        }
    }
}

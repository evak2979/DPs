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
    }
}

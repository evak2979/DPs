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
    }
}

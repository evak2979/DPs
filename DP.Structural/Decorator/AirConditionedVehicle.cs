using DP.Domain.Abstracts;
using DP.Domain.Interfaces;

namespace DP.Structural.Decorator
{
    //Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
    public class AirConditionedVehicle : AbstractVehicle
    {
        private readonly IVehicleOption _vehicle;

        public AirConditionedVehicle(IVehicleOption vehicle) : base(vehicle.Engine)
        {
            _vehicle = vehicle;
        }

        public override int Price => _vehicle.Price + 300;
    }
}

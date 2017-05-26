using DP.Domain.Engines;
using DP.Domain.Interfaces;
using DP.Domain.Vehicles;

namespace DP.Creational.FactoryMethod
{
    public class VanFactory : VehicleFactory
    {
        protected override IVehicle SelectVehicle(DrivingStyle style)
        {
            switch (style)
            {
                case DrivingStyle.Economical:
                case DrivingStyle.Midrange:
                    return new BoxVan(new StandardEngine(1600));
                default:
                    return new PickUp(new TurboEngine(2000));
            }
        }
    }
}

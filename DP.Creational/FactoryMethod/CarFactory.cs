using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Domain.Engines;
using DP.Domain.Interfaces;
using DP.Domain.Vehicles;

namespace DP.Creational.FactoryMethod
{
    public class CarFactory : VehicleFactory
    {
        protected override IVehicle SelectVehicle(DrivingStyle style)
        {
            switch (style)
            {
                case DrivingStyle.Midrange:
                    return new Coupe(new StandardEngine(1600));
                case DrivingStyle.Powerful:
                    return new Sport(new TurboEngine(2000));
                default:
                    return new Saloon(new StandardEngine(1300));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Domain.Abstracts;
using DP.Domain.Engines;
using DP.Domain.Enums;
using DP.Domain.Interfaces;
using DP.Domain.Vehicles;

namespace DPs.Creational.Factory
{
    public abstract class VehicleFactory
    {
        public enum VehicleType
        {
            Car,
            Van
        }

        protected virtual IVehicle Build(VehicleType type, VehicleColour colour)
        {
            return new Coupe(new TurboEngine(2000), colour);
        }

        private static IVehicle GetFactory(VehicleType type, DrivingStyle style, VehicleColour colour)
        {
            VehicleFactory factory;
            switch (type)
            {
                case VehicleType.Car:
                    factory = new CarVehicleFactory();
                    break;
                case VehicleType.Van:
                    factory = new CarVehicleFactory();
                    break;
                default:
                    factory = null;
                    break;
            }

            return factory.Build(type, colour);
        }
    }
}

using DP.Domain.Enums;
using DP.Domain.Interfaces;

namespace DP.Creational.FactoryMethod
{
    //Define an interface for creating an object, but let subclasses decide which class to instantiate.
    public abstract class VehicleFactory
    {
        public enum DrivingStyle
        {
            Economical, Midrange, Powerful
        }

        protected virtual IVehicle Build(DrivingStyle style, VehicleColour colour)
        {
            IVehicle v = SelectVehicle(style);
            v.Paint(colour);
            return v;
        }

        public static IVehicle Make(Category category, DrivingStyle drivingStyle, VehicleColour vehicleColour)
        {
            VehicleFactory factory;
            switch (category)
            {
                case Category.Car:
                    factory = new CarFactory();
                    break;
                default:
                    factory = new VanFactory();
                    break;
            }

            return factory.Build(drivingStyle, vehicleColour);
        }

        protected abstract IVehicle SelectVehicle(DrivingStyle style);

        public enum Category
        {
            Car,
            Van
        }
    }
}

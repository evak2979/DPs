namespace DP.Creational.AbstractFactory
{
    public class CarFactory : IVehicleFactory
    {
        public IBody CreateBody()
        {
            return new CarBody();
        }

        public IChassis CreateChassis()
        {
            return new CarChassis();
        }

        public IGlassware CreateGlassware()
        {
            return new CarGlassware();
        }
    }
}
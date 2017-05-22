namespace DP.Creational.AbstractFactory
{
    public class VanFactory : IVehicleFactory
    {
        public IBody CreateBody()
        {
            return new VanBody();
        }

        public IChassis CreateChassis()
        {
            return new VanChassis();
        }

        public IGlassware CreateGlassware()
        {
            return new VanGlassware();
        }
    }
}
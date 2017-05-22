namespace DP.Creational.AbstractFactory
{
    //Provide an interface for creating families of related or dependent objects
    //without specifying their concrete classes
    public interface IVehicleFactory
    {
        IBody CreateBody();

        IChassis CreateChassis();

        IGlassware CreateGlassware();
    }
}
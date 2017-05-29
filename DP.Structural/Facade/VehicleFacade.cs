using DP.Domain.Enums;
using DP.Domain.Interfaces;

namespace DP.Structural.Facade
{
    //Provide an interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
    public interface IVehicleFacade
    {
        void PrepareVehicle(IVehicle prepareForSale);
    }
    public class VehicleFacade : IVehicleFacade
    {
        private readonly ISomeOtherClass _someOtherClass;

        public VehicleFacade(ISomeOtherClass someOtherClass)
        {
            _someOtherClass = someOtherClass;
        }
        public void PrepareVehicle(IVehicle prepareForSale)
        {
            prepareForSale.Paint(VehicleColour.Black);
            _someOtherClass.SomeOtherMethod(prepareForSale);
        }
    }

    public interface ISomeOtherClass
    {
        void SomeOtherMethod(IVehicle vehicle);
    }
}

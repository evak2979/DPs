using DP.Domain.Abstracts;
using DP.Domain.Interfaces;

namespace DPs.Creational.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        private AbstractCar _carInProgress;
        public CarBuilder(AbstractCar car)
        {
            _carInProgress = car;
        }

        public override IVehicle Vehicle { get { return _carInProgress; } }
    }
}

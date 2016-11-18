using DP.Domain.Abstracts;
using DP.Domain.Interfaces;

namespace DPs.Creational.Builder
{
    public class VanBuilder : VehicleBuilder
    {
        private AbstractCar _vanInProgress;
        public VanBuilder(AbstractVan van)
        {
            _vanInProgress = van;
        }

        public override IVehicle Vehicle => _vanInProgress;
    }
}

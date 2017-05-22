using DP.Domain.Interfaces;

namespace DP.Creational.Builder
{
    public class CarBuilder: IBuilder
    {
        private readonly IVehicle _vehicle;

        private CarBuilder(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public IVehicle BuildBody()
        {
            return this._vehicle;
        }

        public IVehicle BuildBoot()
        {
            return this._vehicle;
        }

        public IVehicle BuildChassis()
        {
            return this._vehicle;
        }

        public IVehicle BuildPassengerArea()
        {
            return this._vehicle;
        }

        public IVehicle BuildReinforcedStorageArea()
        {
            return this._vehicle;
        }

        public IVehicle BuildWindows()
        {
            return this._vehicle;
        }

        public IVehicle Vehicle => this._vehicle;
    }
}
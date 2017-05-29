using System;
using DP.Domain.Enums;

namespace DP.Domain.Interfaces
{
    public interface IVehicle : ICloneable
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);
    }

    public interface IVehicleOption : IVehicle
    {
        int Price { get; }
    }
}

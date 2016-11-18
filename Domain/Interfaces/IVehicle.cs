using DP.Domain.Enums;

namespace DP.Domain.Interfaces
{
    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
    }
}

using DP.Domain.Interfaces;

namespace DP.Creational.Builder
{
    //separate the construction of a project from its representation
    //so that the same construction process can create different representations
    public interface IBuilder
    {
        IVehicle BuildBody();
        IVehicle BuildBoot();
        IVehicle BuildChassis();
        IVehicle BuildPassengerArea();
        IVehicle BuildReinforcedStorageArea();
        IVehicle BuildWindows();
        IVehicle Vehicle { get; }
    }
}

using DP.Domain.Engines;
using DP.Domain.Interfaces;
using DP.Domain.Vehicles;

namespace DP.Creational.Prototype
{
    //Specify the kinds of objects to create using a protototypical instance, and create new objects by copying the prototype
    public class VehicleManager
    {
        private IVehicle saloon, coupe, sport, boxvan, pickup;

        public VehicleManager()
        {
            saloon = new Saloon(new StandardEngine(1300));
            coupe = new Coupe(new StandardEngine(1300));
            sport = new Sport(new StandardEngine(1300));
            boxvan = new BoxVan(new StandardEngine(1300));
            pickup = new PickUp(new StandardEngine(1300));
        }

        public virtual IVehicle CreateSaloon()
        {
            return (IVehicle) saloon.Clone();
        }

        public virtual IVehicle CreateCoupe()
        {
            return (IVehicle)coupe.Clone();
        }

        public virtual IVehicle CreateSport()
        {
            return (IVehicle)sport.Clone();
        }

        public virtual IVehicle CreateBoxvan()
        {
            return (IVehicle)boxvan.Clone();
        }

        public virtual IVehicle CreatePickup()
        {
            return (IVehicle)pickup.Clone();
        }
    }
}

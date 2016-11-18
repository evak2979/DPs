using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Domain.Abstracts;
using DP.Domain.Concretes.Creational;
using DP.Domain.Interfaces;

namespace DPs.Creational
{
    public class CarFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new CarBody();
        }

        public override IChassis CreateChassis()
        {
            return new CarChassis();
        }

        public override IGlassware CreateGlassware()
        {
            return new CarGlassware();
        }
    }
}

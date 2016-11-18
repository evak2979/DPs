﻿using DP.Domain.Enums;
using DP.Domain.Interfaces;

namespace DP.Domain.Abstracts
{
    public class AbstractVehicle : IVehicle
    {
        private IEngine _engine;
        private VehicleColour _colour;

        public IEngine Engine => _engine;
        public VehicleColour Colour => _colour;

        public AbstractVehicle(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
            
        }

        public AbstractVehicle(IEngine engine, VehicleColour colour)
        {
            this._engine = engine;
            this._colour = colour;
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + Engine + ", " + Colour + ")";
        }
    }
}
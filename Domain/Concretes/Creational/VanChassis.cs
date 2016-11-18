﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Domain.Interfaces;

namespace DP.Domain.Concretes.Creational
{
    public class VanChassis : IChassis
    {
        public string ChassisParts => "Chassis parts of a van";
    }
}

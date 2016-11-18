using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Domain.Abstracts;

namespace DP.Domain.Engines
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size, bool turbo) : base(size, turbo)
        {
        }
    }
}

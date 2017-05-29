using System.Collections.Generic;
using DP.Domain.Engines;
using DP.Domain.Interfaces;

namespace DP.Structural.Flyweight
{
    //Use sharing to support large numbers of fine grained objects efficiently
    public class EngineFlyweightFactory
    {
        private IDictionary<int, IEngine> _standardEnginePool;
        private IDictionary<int, IEngine> _turboEnginePool;

        public EngineFlyweightFactory()
        {
            _standardEnginePool = new Dictionary<int, IEngine>();
            _turboEnginePool = new Dictionary<int, IEngine>();
        }

        public virtual IEngine GetStandardEngine(int size)
        {
            if (!_standardEnginePool.ContainsKey(size))
            {
                _standardEnginePool.Add(size, new StandardEngine(size));
            }

            return _standardEnginePool[size];
        }

        public virtual IEngine GetTurboEngine(int size)
        {
            if (!_turboEnginePool.ContainsKey(size))
            {
                _turboEnginePool.Add(size, new TurboEngine(size));
            }

            return _turboEnginePool[size];
        }
    }
}


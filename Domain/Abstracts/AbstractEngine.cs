using DP.Domain.Interfaces;

namespace DP.Domain.Abstracts
{


    public abstract class AbstractEngine : IEngine
    {
        private int _size;
        private bool _turbo;

        public AbstractEngine(int size, bool turbo)
        {
            this._size = size;
            this._turbo = turbo;
        }

        public virtual int Size => _size;

        public virtual bool Turbo => _turbo;

        public override string ToString()
        {
            return this.GetType().Name + " (" + _size + ") ";
        }
    }
}

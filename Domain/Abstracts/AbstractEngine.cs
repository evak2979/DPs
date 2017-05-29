using DP.Domain.Interfaces;

namespace DP.Domain.Abstracts
{


    public abstract class AbstractEngine : IEngine
    {
        private int _size;
        private bool _turbo;
        private bool _running;
        private int _power;

        public AbstractEngine(int size, bool turbo)
        {
            this._size = size;
            this._turbo = turbo;
            _running = false;
            _power = 0;
        }

        public virtual int Size => _size;

        public virtual bool Turbo => _turbo;
        public void Start()
        {
            _running = true;
        }

        public void Stop()
        {
            _running = false;
        }

        public void IncreasePower()
        {
            if ((_running) && _power < 10)
            {
                _power++;
            }
        }

        public void DecreasePower()
        {
            if ((_running) && _power > 0)
            {
                _power--;
            }
        }

        public void Diagnose(IDiagnosticTool tool)
        {
            tool.RunDiagnosis(this);
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + _size + ") ";
        }
    }
}

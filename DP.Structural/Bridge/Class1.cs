using DP.Domain.Interfaces;

namespace DP.Structural.Bridge
{
    //Decouple an abstraction from its implementation so that each may vary independently.
    public class AbstractDriverControls
    {
        private readonly IEngine _engine;

        public AbstractDriverControls(IEngine engine)
        {
            _engine = engine;
        }

        public virtual void IgnitionOn()
        {
            _engine.Start();
        }

        public virtual void IgnitionOff()
        {
            _engine.Stop();
        }

        public virtual void Accelerate()
        {
            _engine.IncreasePower();
        }

        public virtual void Brake()
        {
            _engine.DecreasePower();
        }
    }

    public class StandardControls : AbstractDriverControls
    {
        public StandardControls(IEngine engine) : base(engine)
        {
        }
    }

    public class SportControls : AbstractDriverControls
    {
        public SportControls(IEngine engine) : base(engine)
        {
        }

        public virtual void AccelerateHard()
        {
            Accelerate();
            Accelerate();
        }
    }
}

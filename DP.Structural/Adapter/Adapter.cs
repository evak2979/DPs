using DP.Domain.Abstracts;

namespace DP.Structural
{
    //Convert the interface of a class into the interface clients expect, letting classes work together that couldn't otherwise
    //because of incompatible types
    public class SuperEngineAdapter : AbstractEngine
    {
        public SuperEngineAdapter(SuperGreenEngine engine) : base(engine.EngineSize, false)
        {
            
        }
    }

    public class SuperGreenEngine
    {
        public int EngineSize { get; set; }
        public SuperGreenEngine(int engineSize)
        {
            
        }
    }
}

using System;
using System.Threading;

namespace DP.Domain.Interfaces
{
    public interface IEngine
    {
        int Size { get; }
        bool Turbo { get; }

        void Start();
        void Stop();
        void IncreasePower();
        void DecreasePower();
        void Diagnose(IDiagnosticTool tool);
    }

    public interface IDiagnosticTool
    {
        void RunDiagnosis(object obj);
    }

    public class DiagnosticTool : IDiagnosticTool
    {
        public void RunDiagnosis(object obj)
        {
            Console.WriteLine($"Starting diagnostic tool for{obj}");
            Thread.Sleep(5000);
            Console.WriteLine("Engine diagnosis complete");
        }
    }
}

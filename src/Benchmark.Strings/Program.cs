using BenchmarkDotNet.Running;

namespace Benchmark.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = BenchmarkRunner.Run<ToString_vs_Interpolation>();
        }
    }
}

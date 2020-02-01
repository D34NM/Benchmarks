using BenchmarkDotNet.Running;

namespace Benchmark.Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = BenchmarkRunner.Run<Benchmarks>();
        }
    }
}

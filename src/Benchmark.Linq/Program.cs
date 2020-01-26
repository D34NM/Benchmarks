using Benchmark.Linq.Projections;
using BenchmarkDotNet.Running;

namespace Benchmark.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ProjectionImpl>();
        }
    }
}

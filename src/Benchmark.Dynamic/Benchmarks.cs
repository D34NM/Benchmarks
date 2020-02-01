using BenchmarkDotNet.Attributes;

namespace Benchmark.Dynamic
{
    [MValueColumn]
    public class Benchmarks
    {
        private Runner _runner;
        private dynamic _dynamicRunner;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _runner = new Runner();
            _dynamicRunner = new Runner();
        }

        [Benchmark]
        public void Static_Invocation()
        {
            var _ = _runner.Run();
        }

        [Benchmark]
        public void Dynamic_Invocation()
        {
            var _ = _dynamicRunner.Run();
        }
    }
}

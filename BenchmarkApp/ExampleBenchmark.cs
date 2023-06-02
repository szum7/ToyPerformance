using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace BenchmarkApp
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class ExampleBenchmark
    {
        /// <summary>
        /// An example benchmark.
        /// </summary>
        [Benchmark(Baseline = true)]
        [Arguments(0, 1)]
        [Arguments(1, 2)]
        [Arguments(12345, 67890)]
        public void ExampleSolution(int param1, int param2)
        {
            var result = new ExampleSolution().BogusAddition(param1, param2);
        }
    }
}

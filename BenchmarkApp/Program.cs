using BenchmarkDotNet.Running;

namespace BenchmarkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ExampleBenchmark>();

            Console.WriteLine($"END of {nameof(BenchmarkApp)}. Version 1.0");
        }
    }
}
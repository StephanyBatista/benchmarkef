using System;
using BenchmarkDotNet.Running;
using benchmarkef.Insert;
using benchmarkef.Select;

namespace benchmarkef
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Benchmark));
            
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

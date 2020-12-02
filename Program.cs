using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace DictionaryBenchmarks
{
    class Program
    {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, new DebugInProcessConfig());
    }
}

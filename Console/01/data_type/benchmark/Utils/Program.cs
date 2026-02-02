using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Filters;
using BenchmarkDotNet.Running;
using Utils.Benchmark;

string? method = null;

for (int i = 0; i < args.Length; i++)
{
    if (args[i] == "--method" && i + 1 < args.Length)
    {
        method = args[i + 1];
    }
}

var config = ManualConfig.Create(DefaultConfig.Instance);

if (!string.IsNullOrWhiteSpace(method))
{
    config = config.AddFilter(
        new NameFilter(name => name.Contains(method))
    );
}

BenchmarkRunner.Run<NumberBenchmarks>(config);

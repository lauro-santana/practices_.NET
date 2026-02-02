using BenchmarkDotNet.Attributes;
using Utils.Type;

namespace Utils.Benchmark;

[MemoryDiagnoser] // shows allocations
public class NumberBenchmarks
{
    [Benchmark]
    public string? AsStringInt()
    {
        return Number.AsString(123);
    }

    [Benchmark]
    public string? AsStringDecimal()
    {
        return Number.AsString(123.45m);
    }

    [Benchmark]
    public decimal AsDecimal()
    {
        return Number.AsDecimal(10, 25);
    }
}

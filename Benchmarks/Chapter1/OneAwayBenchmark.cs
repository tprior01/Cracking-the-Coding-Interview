namespace ConsoleApp1.Benchmarks.Chapter1;

using ConsoleApp1.Chapter1;
using BenchmarkDotNet.Attributes;

public static class OneAwayTestData
{
    public static readonly (string, string) Tuple1 = ("pale", "ple");
    public static readonly (string, string) Tuple2 = ("pales", "pale");
    public static readonly (string, string) Tuple3 = ("pale", "bale");
    public static readonly (string, string) Tuple4 = ("pales", "bake");
}

public class OneAwayBenchmark
{
    [Benchmark]
    public void OneAway1Benchmarks()
    {
        OneAway.OneAway1(OneAwayTestData.Tuple1.Item1, OneAwayTestData.Tuple1.Item2);
        OneAway.OneAway1(OneAwayTestData.Tuple2.Item1, OneAwayTestData.Tuple2.Item2);
        OneAway.OneAway1(OneAwayTestData.Tuple3.Item1, OneAwayTestData.Tuple3.Item2);
        OneAway.OneAway1(OneAwayTestData.Tuple4.Item1, OneAwayTestData.Tuple4.Item2);
    }

    [Benchmark]
    public void OneAway2Benchmarks()
    {
        OneAway.OneAway2(OneAwayTestData.Tuple1.Item1, OneAwayTestData.Tuple1.Item2);
        OneAway.OneAway2(OneAwayTestData.Tuple2.Item1, OneAwayTestData.Tuple2.Item2);
        OneAway.OneAway2(OneAwayTestData.Tuple3.Item1, OneAwayTestData.Tuple3.Item2);
        OneAway.OneAway2(OneAwayTestData.Tuple4.Item1, OneAwayTestData.Tuple4.Item2);
    }
}
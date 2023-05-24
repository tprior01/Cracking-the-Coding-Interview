namespace ConsoleApp1.Benchmarks.Chapter1;

using ConsoleApp1.Chapter1;
using BenchmarkDotNet.Attributes;

public static class CheckPermutationTestData
{
    public const String String1 = "abcdefghijklmnopqrstuvwxyz!ABCDEFGHIJKLMNOPQRSTUVWX?<>@£$%^&*()";
    public const String String2 = "ABCDEFGHIJKLMNOPQRSTUVWX?<>@£$%^&*()abcdefghijklmnopqrstuvwxyz!";
}

public class CheckPermutationBenchmark
{
    [Benchmark]
    public void IsPermutation2Test()
    {
        CheckPermutation.CheckPermutation2(CheckPermutationTestData.String1, CheckPermutationTestData.String2);
    }

    [Benchmark]
    public void IsPermutation3Test()
    {
        CheckPermutation.CheckPermutation3(CheckPermutationTestData.String1, CheckPermutationTestData.String2);
    }
}
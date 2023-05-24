namespace ConsoleApp1.Benchmarks.Chapter1;

using ConsoleApp1.Chapter1;
using BenchmarkDotNet.Attributes;

public static class URLifyTestData
{
    public const string String1 = "Mr John Smith       ";
    public const int Len = 13;
}

public class URLifyBenchmark
{
    [Benchmark]
    public void URLify2Test()
    {
        URLify.URLify2(URLifyTestData.String1, URLifyTestData.Len);
    }
        
    [Benchmark]
    public void URLify3Test()
    {
        URLify.URLify3(URLifyTestData.String1, URLifyTestData.Len);
    }
        
    [Benchmark]
    public void URLify4Test()
    {
        URLify.URLify4(URLifyTestData.String1, URLifyTestData.Len);
    }
}
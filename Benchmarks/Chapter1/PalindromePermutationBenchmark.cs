namespace ConsoleApp1.Benchmarks.Chapter1;

using ConsoleApp1.Chapter1;
using BenchmarkDotNet.Attributes;


public static class PalindromePermutationTestData
{
    public const string String1 = "det artRa tEd";
    public const string String2 = "Tact Coa";
}


public class PalindromePermutationBenchmark
{
    [Benchmark]
    public void PalindromePermutation2Test()
    { 
        PalindromePermutation.PalindromePermutation2(PalindromePermutationTestData.String1);
        PalindromePermutation.PalindromePermutation2(PalindromePermutationTestData.String2);
    }
        
    [Benchmark]
    public void PalindromePermutation3Test()
    { 
        PalindromePermutation.PalindromePermutation3(PalindromePermutationTestData.String1);
        PalindromePermutation.PalindromePermutation3(PalindromePermutationTestData.String2);
    }
        
    [Benchmark]
    public void PalindromePermutation4Test()
    { 
        PalindromePermutation.PalindromePermutation4(PalindromePermutationTestData.String1);
        PalindromePermutation.PalindromePermutation4(PalindromePermutationTestData.String2);
    }
}
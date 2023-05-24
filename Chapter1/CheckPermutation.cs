namespace ConsoleApp1.Chapter1;
using System.Collections.Generic;

public class CheckPermutation
{
    /**
	 * CheckPermutation1: Time Complexity: O(nLogn), Space Complexity: O(1)
     * CheckPermutation2: Time Complexity: O(n), Space Complexity: O(n)
     * CheckPermutation3: Time Complexity: O(n), Space Complexity: O(n)
     *
     * |             Method |       Mean |   Error |  StdDev |
     * |------------------- |-----------:|--------:|--------:|
     * | IsPermutation2Test | 2,744.0 ns | 8.10 ns | 7.18 ns |
     * | IsPermutation3Test |   317.6 ns | 0.72 ns | 0.67 ns |
     *
     * Test strings:
     *    "abcdefghijklmnopqrstuvwxyz!ABCDEFGHIJKLMNOPQRSTUVWX?<>@£$%^&*()";
     *    "ABCDEFGHIJKLMNOPQRSTUVWX?<>@£$%^&*()abcdefghijklmnopqrstuvwxyz!";
	 */
    public static bool CheckPermutation1(string str1, string str2)
    
    {
        if (str1.Length != str2.Length) return false;
        
        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);
        
        for (int i = 0; i < arr1.Length; i++)
            if (str1[i] == str2[i])
                return false;
        return true;
    }

    public static bool CheckPermutation2(string str1, string str2)
    {
        if (str1.Length != str2.Length) return false;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int value;
        foreach (char c in str1)
            dict[c] = dict.TryGetValue(c, out value) ? value + 1 : 1;
        foreach (char c in str2)
            dict[c] = dict.TryGetValue(c, out value) ? value - 1 : 1;
        foreach (char c in dict.Keys)
            if (dict[c] != 0)
                return false;
        return true;
    }

    public static bool CheckPermutation3(string str1, string str2)
    {
        if (str1.Length != str2.Length) return false;
        int[] count = new int[255];
        foreach (char c in str1)
            count[c] = count[c] += 1;
        foreach (char c in str2)
            count[c] = count[c] -= 1;
        foreach (int i in count)
            if (i != 0)
                return false;
        return true;
    }
}
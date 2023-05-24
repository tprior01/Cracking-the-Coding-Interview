namespace ConsoleApp1.Chapter1;

using System.Collections.Generic;

public class PalindromePermutation
{
    /**
	 * PalindromePermutation1: Time Complexity: O(n^2), Space Complexity: O(1)
	 * PalindromePermutation2: Time Complexity: O(n), Space Complexity: O(n)
     * PalindromePermutation3: Time Complexity: O(n), Space Complexity: O(1)
     * PalindromePermutation4: Time Complexity: O(n), Space Complexity: O(1)
     *
     * |                     Method |      Mean |    Error |   StdDev |
     * |--------------------------- |----------:|---------:|---------:|
     * | PalindromePermutation2Test | 414.36 ns | 1.138 ns | 1.065 ns |
     * | PalindromePermutation3Test | 121.64 ns | 0.253 ns | 0.212 ns |
     * | PalindromePermutation4Test |  90.07 ns | 0.734 ns | 0.686 ns |
     *
     * Test strings:
     *   "det artRa tEd"
     *   "Tact Coa"
	 */

    public static bool PalindromePermutation1(string str)
    {
        str = str.ToLower();
        char[] charArray = str.ToCharArray();
        Array.Sort(charArray);
        int odd = 0;
        int count = 0;
        for (int i = 1; i < charArray.Length; i++)
            if (char.IsLetter(charArray[i - 1]) && char.IsLetter(charArray[i]))
                if (charArray[i - 1] == charArray[i])
                {
                    count++;

                }
                else
                {
                    if (count % 2 != 0)
                    { 
                        count = 0;
                        continue;
                    }

                    count = 0;
                    odd++;
                    if (odd > 1)
                        return false;
                }
        return true;
    }
    
    public static bool PalindromePermutation2 (string str)
    {
        int odd = 0;
        Dictionary<int, int> dict = new Dictionary<int, int> ();
        foreach (char c in str)
            if (char.IsUpper(c))
                dict[c - 65] = dict.TryGetValue(c, out var value) ? value + 1 : 1;
            else if (char.IsLower(c))
                dict[c - 97] = dict.TryGetValue(c, out var value) ? value - 1 : 1;
        foreach (int i in dict.Values)
            if (i != 0)
            {
                odd++;
                if (odd > 1)
                    return false;
            }

        return true;
    }

    public static bool PalindromePermutation3(string str)
    {
        bool[] boolArray = new bool[26];
        int odd = 0;
        foreach (char c in str)
            if (char.IsUpper(c))
                boolArray[c - 65] = !boolArray[c - 65];
            else if (char.IsLower(c))
                boolArray[c - 97] = !boolArray[c - 97];
        foreach (bool b in boolArray)
        {
            if (b)
            {
                odd++;
                if (odd > 1)
                    return false;
            }
        }

        return true;
    }
    
    public static bool PalindromePermutation4(string str)
    {
        int[] count = new int[26];
        int odd = 0;
        foreach (char c in str)
            if (char.IsUpper(c))
                count[c - 65] += 1;
            else if (char.IsLower(c))
                count[c - 97] -= 1;
        foreach (int i in count)
        {
            if (i != 0)
            { 
                odd++;
                if (odd > 1)
                    return false;
            }
        }

        return true;
    }
}
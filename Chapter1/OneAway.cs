namespace ConsoleApp1.Chapter1;

public class OneAway
{
    /**
	 * OneAway1: Time Complexity: O(n), Space Complexity: O(1)
     * OneAway2: Time Complexity: O(n), Space Complexity: O(1)
     *
     * |             Method |     Mean |    Error |   StdDev |
     * |------------------- |---------:|---------:|---------:|
     * | OneAway1Benchmarks | 49.06 ns | 0.027 ns | 0.024 ns |
     * | OneAway2Benchmarks | 46.71 ns | 0.043 ns | 0.040 ns |
     *
     * Test data:
     *    Tuple1 = ("pale", "ple");
     *    Tuple2 = ("pales", "pale");
     *    Tuple3 = ("pale", "bale");
     *    Tuple4 = ("pales", "bake");
	 */
    public static bool OneAway1(string str1, string str2)
    {
        int m = str1.Length, n = str2.Length;
        
        if (Math.Abs(m - n) > 1)
            return false;

        int count = 0;
        int i = 0, j = 0;
         
        while (i < m && j < n)
        {
            if (str1[i] != str2[j])
            {
                if (count == 1)
                    return false;

                if (m > n)
                    i++;
                else if (m< n)
                    j++;
                
                else
                {
                    i++;
                    j++;
                }
             
                count++;
            }
 
            else
            {
                i++;
                j++;
            }
        }
        
        if (i < m || j < n)
            count++;
 
        return count == 1;
    }

    public static bool OneAway2(string str1, string str2)
    {
        
        int l1 = str1.Length, l2 = str2.Length;
        
        if (Math.Abs(l1 - l2) > 1)
            return false;

        int i = 0, j = 0, count = 0;

        while (i < l1 && j < l2)
        {
            if (str1[i] != str2[j])
            {
                count++;
                if (count > 1)
                    return false;
                if (l1 > l2)
                    i++;
                else if (l2 > l1)
                    j++;
                else
                {
                    i++;
                    j++;
                }
            }
            else
            {
                i++;
                j++;
            }
        }

        return true;
    }
}
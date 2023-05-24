namespace ConsoleApp1.Chapter1;

using System.Text;


public class URLify
{
    /**
	 * URLify1: Time Complexity: O(n^2), Space Complexity: O(1)
     * URLify2: Time Complexity: O(n), Space Complexity: O(1)
     * URLify3: Time Complexity: O(n), Space Complexity: O(1)
     * URLify4: Time Complexity: O(n), Space Complexity: O(1)
     *
     * |      Method |      Mean |    Error |   StdDev |
     * |------------ |----------:|---------:|---------:|
     * | URLify2Test |  71.01 ns | 0.443 ns | 0.370 ns |
     * | URLify3Test |  72.08 ns | 0.277 ns | 0.231 ns |
     * | URLify4Test |  68.89 ns | 1.297 ns | 1.149 ns |
     *
     * Test input:
     *    ("Mr John Smith       ", 13)
	 */

    public static string URLify1(string str, int len)
    {
        char[] oldStr = str.ToCharArray();
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < len; i++)
            stringBuilder.Append(oldStr[i] == ' ' ? "%20" : oldStr[i].ToString());
        return stringBuilder.ToString().TrimEnd();
    }

    public static string URLify2(string str, int len)
    {
        return str.TrimEnd().Replace(" ", "%20");
    }

    public static string URLify3(string str, int len)
    {
        char[] charArray = str.ToCharArray();
        int spaces = 0;
        int head;
        for (int i = 0; i < len; i++)
            if (charArray[i] == ' ')
                spaces++;
        head = len + spaces * 2 - 1;
        for (int i = len - 1; i >= 0; i--) 
        { 
            if (charArray[i] == ' ') {
                charArray[head] = '0';
                charArray[head - 1] = '2';
                charArray[head - 2] = '%';
                head -= 3;
			} else {
                charArray[head] = charArray[i];
                head--;
			}
        }

        return new String(charArray).TrimEnd();
    }
    
    
    public static string URLify4(string str, int len)
    {
        char[] charArray = str.ToCharArray();
        int spaces = 0;
        int head;
        for (int i = 0; i < len; i++)
            if (charArray[i] == ' ')
                spaces++;
        head = len + spaces * 2 - 1;
        for (int i = len - 1; i >= 0; i--) 
        { 
            if (charArray[i] == ' ') {
                charArray[head] = '0';
                charArray[head - 1] = '2';
                charArray[head - 2] = '%';
                head -= 3;
            } else {
                charArray[head] = charArray[i];
                head--;
            }
        }

        return new String(charArray[..(len + spaces * 2)]);
    }
}
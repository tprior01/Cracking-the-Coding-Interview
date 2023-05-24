using System.Text;

namespace ConsoleApp1.Chapter1;

public class StringRotation
{
    /**
     * StringRotation1: Time Complexity: O(n^2), Space Complexity: O(n), this including isSubstring method
	 */

    public static bool StringRotation1(string s1, string s2)
    {
        return isSubstring(s1, s2 + s2);
    }

    public static bool isSubstring(string s1, string s2)
    {
        return s2.IndexOf(s1) >= 0;
    }
}
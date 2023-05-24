namespace ConsoleApp1.Chapter1;

using System.Text;


public class StringCompression
{
    /**
	 * StringCompression1: Time Complexity: O(n^2), Space Complexity: O(n)
	 */
    public static string StringCompression1(string str) {
        StringBuilder stringBuilder = new StringBuilder(str.Length + 1);
        char character = str[0];
        int count = 1;
        for (int i = 1; i < str.Length; i++) {
            if (str[i] == character) {
                count++;
            } else {
                stringBuilder.Append(character);
                stringBuilder.Append(count);
                if(stringBuilder.Length > str.Length) {
                    return str;
                }
                character = str[i];
                count = 1;
            }
        }
        stringBuilder.Append(character);
        stringBuilder.Append(count);
        return stringBuilder.ToString();
    }
}
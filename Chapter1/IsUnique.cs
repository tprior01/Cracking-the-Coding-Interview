namespace ConsoleApp1.Chapter1;

public class IsUnique
{
    /**
	 * IsUnique1: Time Complexity: O(n^2), Space Complexity: O(1)
     * IsUnique2: Time Complexity: O(nLogn), Space Complexity: O(1)
     * IsUnique3: Time Complexity: O(n), Space Complexity: O(n)
	 */
    public static bool IsUnique1(string str)
    {
        for (int i=0; i < str.Length; i++)
            for (int j=i+1; j < str.Length; j++)
                if (str[i] == str[j])
                    return false;
        return true;
    }

    public static bool IsUnique2(string str)
    
    {
        char[] arr = str.ToCharArray();
        
        Array.Sort(arr);

        for (int i = 0; i < str.Length - 1; i++)
            if (arr[i] == arr[i + 1]) return false;
        return true;
    }
    
    public static bool IsUnique3(string str)
    {
        bool[] arr = new bool[255];

        foreach (char c in str)
        {
            if (arr[c]) return false;
            arr[c] = true;

        }
        return true;
    }
    
    
}
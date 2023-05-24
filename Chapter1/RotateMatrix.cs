namespace ConsoleApp1.Chapter1;

public class RotateMatrix
{
    /**
	 * RotateMatrix1: Time Complexity: O(n^2), Space Complexity: O(1)
	 */
    public static int[,] RotateMatrix1(int[,] matrix)
    {
        int len = matrix.GetLength(0) - 1;
        for (int i = 0; i <= len / 2; i++)
            for (int j = 0; j <= len / 2; j++)
            {
                int temp = matrix[i, j];

                matrix[i, j] = matrix[j, len - i];
                matrix[j, len - i] = matrix[len - i, len - j];
                matrix[len - i, len - j] = matrix[len - j, i];
                matrix[len - j, i] = temp;
            }

        return matrix;
    }
    
    public static void Print2DArray<T>(T[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
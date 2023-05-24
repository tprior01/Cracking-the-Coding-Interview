namespace ConsoleApp1.Chapter1;

public class ZeroMatrix
{
    /**
	 * ZeroMatrix1: Time Complexity: O(n*m), Space Complexity: O(1)
	 */
    public static int[,] ZeroMatrix1(int[,] matrix)
    {
        int i, j, xDim = matrix.GetLength(0), yDim = matrix.GetLength(1);
        
        for (i = 0; i < xDim; i++)
            for (j = 0; j < yDim; j++)
                if (matrix[i, j] == 0)
                {
                    matrix[0, j] = 0;
                    matrix[i, 0] = 0;
                }
        for (i = 0; i < xDim; i++)
            if (matrix[i, 0] == 0)
                for (j = 0; j < yDim; j++)
                    matrix[i, j] = 0;
        for (j = 0; j < yDim; j++)
            if (matrix[0, j] == 0)
                for (i = 0; i < xDim; i++)
                    matrix[i, j] = 0;
        
        return matrix;
    }
}
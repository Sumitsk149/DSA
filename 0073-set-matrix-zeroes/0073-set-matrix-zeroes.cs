public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        int rows = matrix.Length;
        int columns = matrix[0].Length;

        bool firstRowZero = false;
        bool firstColumnZero = false;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (i == 0 && matrix[i][j] == 0)
                {
                    firstRowZero = true;
                }
                if (j == 0 && matrix[i][j] == 0)
                {
                    firstColumnZero = true;
                }
                else if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0; // Mark the first column
                    matrix[0][j] = 0; // Mark the first row
                }
            }
        }

        // Set the cells to zero based on the marks
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (i == 0 || j == 0) continue; // Skip the top-left cell
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        // Set the first row to zero if needed
        if (firstRowZero)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[0][j] = 0;
            }
        }

        // Set the first column to zero if needed
        if (firstColumnZero)
        {
            for (int i = 0; i < rows; i++)
            {
                matrix[i][0] = 0;
            }
        }
    }
}
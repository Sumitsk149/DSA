public class Solution {
    public void Rotate(int[][] matrix) {
        
        int n = matrix[0].Length;

        // 1. transpose matrix
        for(int row = 0; row < n; row++)
        {
          for(int col = 0; col < n; col++)
          {
            if(col > row)
            {
              int temp = matrix[row][col];
              matrix[row][col] = matrix[col][row];
              matrix[col][row] = temp;
            }
          }
        }

        // 2. Switch columns
        for(int row = 0; row < n; row++)
        {
          int firstCol = 0;
          int lastCol = n - 1;
          while(lastCol > firstCol)
          {
            int temp = matrix[row][firstCol];
            matrix[row][firstCol] = matrix[row][lastCol];
            matrix[row][lastCol] = temp;
            firstCol++;
            lastCol--;
          }
        }
    }
}
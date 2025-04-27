public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        int boardLength = board.Length;
        HashSet<char> hs;

        // Iterate rows
        for (int i = 0; i < boardLength; i++)
        {
            hs = new HashSet<char>();
            for (int j = 0; j < boardLength; j++)
            {
                char ele = board[i][j];
                if (ele != '.')
                {
                    if (hs.Contains(ele))
                        return false;
                    hs.Add(ele);
                }
            }
        }

        // Iterate columns
        for (int i = 0; i < boardLength; i++)
        {
            hs = new HashSet<char>();
            for (int j = 0; j < boardLength; j++)
            {
                char ele = board[j][i];
                if (ele != '.')
                {
                    if (hs.Contains(ele))
                        return false;
                    hs.Add(ele);
                }
            }
        }

        return CheckMatrix(board);
    }

    private bool CheckMatrix(char[][] board)
    {
        int boardLength = board.Length;
        for (int i = 0; i < boardLength; i += 3)
        {
            for (int j = 0; j < boardLength; j += 3)
            {
                if (!CheckSubMatrix(i, j, board))
                {
                    return false;
                }
            }
        }
        return true;
    }

    private bool CheckSubMatrix(int a, int b, char[][] board)
    {
        HashSet<char> hs = new HashSet<char>();
        for (int i = a; i < a + 3; i++)
        {
            for (int j = b; j < b + 3; j++)
            {
                char ele = board[i][j];
                if (ele != '.')
                {
                    if (hs.Contains(ele))
                        return false;
                    hs.Add(ele);
                }
            }
        }
        return true;
    }
}

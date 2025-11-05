public class Solution {
    public int NumSquares(int n) {
        var dp = new int[n + 1];

        // Initialize dp array with -1
        for (int i = 0; i <= n; i++) {
            dp[i] = -1;
        }

        return minSquare(n, dp);
    }

    private int minSquare(int n, int[] dp)
    {
        if(n == 0)
            return 0;
        
        if(dp[n] == -1)
        {
            int ans = int.MaxValue;
            for(int x = 1; x * x <= n; x++)
            {
                ans = Math.Min(ans, minSquare(n - (x * x), dp));
            }

            dp[n] = 1 + ans;
        }

        return dp[n];
    }
}
public class Solution {
    //Used top-down approach
    public int ClimbStairs(int n) 
    {
        var dp = new int[n+1];
        Array.Fill(dp, -1);

        return climb(n, dp);
    }

    private int climb(int n, int[] dp)
    {
        if(n <= 1)
            return 1;

        if(dp[n] == -1)
            dp[n] = climb(n - 1, dp) + climb(n - 2, dp);
        
        return dp[n];
    }
}
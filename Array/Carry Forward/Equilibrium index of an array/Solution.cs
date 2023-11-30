class Solution
{
    public int solve(List<int> A)
    {
        //using carry forward approach 
        //alternatively we can use prefix sum also 
        //but it will increase space complexity to n

        int n = A.Count;
        int totalsum = 0;
        for (int i = 0; i < n; i++)
        {
            totalsum += A[i];
        }

        int lSum = 0;
        int rSum = 0;
        for (int i = 0; i < n; i++)
        {
            rSum = totalsum - lSum - A[i];
            if (lSum == rSum)
                return i;
            lSum += A[i];
        }
        return -1;
    }
}

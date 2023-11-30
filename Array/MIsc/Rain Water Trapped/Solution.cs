class Solution
{
    public int trap(List<int> A)
    {
        int n = A.Count;

        //Calculate right Max Value for each element
        int[] rMax = new int[n];
        int Max = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            Max = Math.Max(A[i], Max);
            rMax[i] = Math.Max(A[i], Max);
        }

        //Calculate left max value for each element
        //Also check which is min between left max and right max 
        //Calculate the water trapped
        int sum = 0;
        int lMax = 0;
        for (int i = 0; i < n; i++)
        {
            lMax = Math.Max(A[i], lMax);
            int minHeight = Math.Min(lMax, rMax[i]);
            sum += minHeight - A[i];
        }
        return sum;
    }
}

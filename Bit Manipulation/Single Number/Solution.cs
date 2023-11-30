class Solution
{
    public int singleNumber(List<int> A)
    {
        int ans = 0;
        for (int i = 0; i < A.Count; i++)
        {
            ans = ans ^ A[i];
        }
        return ans;
    }
}

class Solution
{
    public int singleNumber(List<int> A)
    {
        int ans = 0;
        for (int i = 0; i < 32; i++)
        {
            int count = 0;
            for (int j = 0; j < A.Count; j++)
            {
                if (isSetBit(A[j], i))
                    count++;
            }
            if (count % 3 == 1)
                ans = ans | (1 << i);
        }
        return ans;
    }

    public bool isSetBit(int num, int pos)
    {
        if ((num & (1 << pos)) > 0)
            return true;
        return false;
    }
}

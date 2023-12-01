class Solution
{
    public int solve(List<int> A)
    {
        int ans = 0;

        for (int bit = 31; bit >= 0; bit--)
        {
            List<int> temp = new List<int>();
            //Add elements with the bit set at position
            for (int i = 0; i < A.Count; i++)
            {
                if ((A[i] & (1 << bit)) != 0)
                {
                    temp.Add(A[i]);
                }
            }
            //If there are at least two elements with the bit set, 
            //that means those number will give max and others we can ignore
            if (temp.Count >= 2)
            {
                A = temp;
            }
        }

        return (A[0] & A[1]);
    }
}

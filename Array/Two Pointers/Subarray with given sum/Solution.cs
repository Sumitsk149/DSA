class Solution
{
    public List<int> solve(List<int> A, int B)
    {

        List<int> ans = new List<int>();
        if (A[0] == B)
        {
            ans.Add(A[0]);
            return ans;
        }

        int i = 0;
        int j = 1;
        int sum = A[i] + A[j];
        int n = A.Count;
        while (i <= j && j < n)
        {
            if (sum == B)
            {
                for (int k = i; k <= j; k++)
                {
                    ans.Add(A[k]);
                }
                return ans;
            }
            else if (sum < B)
            {
                j++;
                if (j < n)
                    sum += A[j];
            }
            else
            {
                sum -= A[i];
                i++;
                if (i > j && i < n - 1)
                {
                    j++;
                    sum += A[j];
                }
            }
        }

        return new List<int>() { -1 };
    }
}

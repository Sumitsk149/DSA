class Solution
{
    public int solve(List<int> A, int B)
    {
        int p1 = 0;
        int p2 = A.Count - 1;
        int ans = 0;
        int mod = 1000000007;
        while (p1 < p2)
        {
            int sum = A[p1] + A[p2];
            if (sum == B)
            {
                if (A[p1] == A[p2])
                {
                    int cnt = (p2 - p1 + 1);
                    cnt = (int)((cnt * 1L * (cnt - 1) / 2) % mod);
                    ans = (ans + cnt) % mod;
                    break;
                }
                else
                {
                    int duplicateP1 = 1;
                    while ((p1 + 1) < p2 && A[p1 + 1] == A[p1])
                    {
                        duplicateP1++;
                        p1++;
                    }

                    int duplicateP2 = 1;
                    while ((p2 - 1) > p1 && A[p2 - 1] == A[p2])
                    {
                        duplicateP2++;
                        p2--;
                    }

                    ans = (int)((ans + (duplicateP1 * 1L * duplicateP2) % mod) % mod);
                    p1++;
                    p2--;
                }
            }
            else if (sum > B)
            {
                p2--;
            }
            else
            {
                p1++;
            }
        }
        return ans;
    }
}
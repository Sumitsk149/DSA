public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        if(m == 0)
        {
            for(int i = 0; i < n; i++)
            {
                nums1[i] = nums2[i];
            }
            return;
        }
        else if(n == 0)
        {
            return;
        }
        else
        {
            int p1 = m - 1;
            int p2 = n - 1;
            int p = nums1.Length - 1;

            while(p1 >=0 && p2 >= 0)
            {
                if(nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[p] = nums2[p2];
                    p2--;
                }                
                p--;
            }

            // If any elements remain in nums2, copy them
            while (p2 >= 0)
            {
                nums1[p] = nums2[p2];
                p2--;
                p--;
            }
        }
    }
}
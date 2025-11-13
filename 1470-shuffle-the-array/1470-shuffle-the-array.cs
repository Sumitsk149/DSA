public class Solution {
    public int[] Shuffle(int[] nums, int n) 
    {
        int[] result = new int[2 * n];

        int j = 0;
        for(int i = 0; i < result.Length; i++)
        {
            if(i % 2 == 0)
            {
                result[i] = nums[j];
            }
            else
            {
                result[i] = nums[n + j];
                j++;
            }
        }

        return result;
    }
}
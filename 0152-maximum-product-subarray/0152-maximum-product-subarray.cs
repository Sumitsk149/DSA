public class Solution 
{
    public int MaxProduct(int[] nums) 
    {
        //Solving this using dp approach.

        int maxSoFar = nums[0];
        int minSoFar = nums[0];
        int result = nums[0];

        for(int i = 1; i < nums.Length; i++)
        {
            int tempMax = Math.Max(nums[i], Math.Max(maxSoFar * nums[i], minSoFar * nums[i]));
            int tempMin = Math.Min(nums[i], Math.Min(maxSoFar * nums[i], minSoFar * nums[i]));

            maxSoFar = tempMax;
            minSoFar = tempMin;

            result = Math.Max(result, maxSoFar);
        }

        return result;

    }
}
public class Solution {
    public double FindMaxAverage(int[] nums, int k) {

        int numLen = nums.Length;
        int sum = nums[0];        
        for (int i = 1; i < k; i++)
        {
            sum += nums[i];            
        }

        int maxSum = sum;
        for(int j = k; j < numLen; j++)
        {
            sum = sum - nums[j - k] + nums[j];
            maxSum = Math.Max(sum, maxSum);
        }

        return (double)maxSum / k;       
    }
}
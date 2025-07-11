public class Solution {
    public int MaxSubArray(int[] nums) {

        int currentSum = nums[0];
        int maxSum = nums[0];

        for(int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], nums[i] + currentSum);
            maxSum = Math.Max(maxSum, currentSum);
        }
        
        return maxSum;
    }
}
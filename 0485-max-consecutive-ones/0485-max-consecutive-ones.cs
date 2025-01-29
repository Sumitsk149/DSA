public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int counter = 0;
        int maxCount = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 1)
            {
                counter++;
            }
            else
            {
                maxCount = Math.Max(counter, maxCount);
                counter = 0;
            }          
        }
        
        maxCount = Math.Max(counter, maxCount);
        return maxCount;
    }
}
public class Solution {
    // Input: nums = [2,0,2,1,1,0]
    // Output: [0,0,1,1,2,2]
    public void SortColors(int[] nums) {
        for(int i = 0; i < nums.Length; i++)
        {
            int minIndex = i;            
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[j] < nums[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = nums[minIndex];
            nums[minIndex] = nums[i];
            nums[i] = temp;
        }
    }
}
public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        int lastNum = nums[0];
        int count = 1;
        int lastNumPosition = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] > lastNum)
            {
                count++;
                nums[lastNumPosition++] = nums[i];
                lastNum = nums[i];
            }
        }

        return count;
    }
}
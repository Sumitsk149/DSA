public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int uniqCount = 1;
        int lastElement = nums[0];        
        int positionToFill = 1;
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != lastElement)
            {
                nums[positionToFill] = nums[i];
                lastElement = nums[i];
                uniqCount++;
                positionToFill++;
            }
        }
        
        return uniqCount;
        
    }
}
public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        int lastNum = nums[0];
        int lastNumCount = 1;
        int lastNumPosition = 1;
        int count = 1;

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] == lastNum && lastNumCount == 1)
            {
                lastNumCount++;
                nums[lastNumPosition] = nums[i];
                lastNumPosition++;
                count++;
            }
            
            if(nums[i] > lastNum)
            {
                lastNum = nums[i];
                lastNumCount = 1;
                nums[lastNumPosition] = nums[i];
                lastNumPosition++;
                count++;
            }     
        }

        return count;
    }
}
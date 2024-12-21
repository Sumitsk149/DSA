public class Solution {
    public void MoveZeroes(int[] nums) {
        int numsLen = nums.Length;
        int zeroCounter = 0;
        for(int i = 0; i < numsLen; i++)
        {
            if(nums[i] == 0)
            {
                zeroCounter++;
            }
            else
            {
                nums[i - zeroCounter] = nums[i];
            }
        }

        if(zeroCounter > 0 && numsLen > 1)
        {
            int i = numsLen - zeroCounter;
            while(i < numsLen)
            {
                nums[i] = 0;
                i++;
            }
        }

    }
}
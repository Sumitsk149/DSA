public class Solution {
    public void MoveZeroes(int[] nums) {
        int numsLen = nums.Length;
        int zeroCount = 0;
        for(int i = 0; i < numsLen; i++)
        {
            if(nums[i] == 0)
            {
                zeroCount++;
            }
            else if(zeroCount > 0)
            {
                var temp = nums[i];
                nums[i] = nums[i - zeroCount];
                nums[i - zeroCount] = temp;
            }
        }
    }
}

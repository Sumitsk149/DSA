public class Solution {
    public int[] FindErrorNums(int[] nums) 
    {
        var count = new int[nums.Length + 1];
        for(int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            count[num]++;
        }

        var result = new int[2];
        for(int i = 1; i < count.Length; i++)
        {
            if(count[i] > 1 && result[0] == 0)
            {
                result[0] = i;
            }
            if(count[i] == 0)
            {
                result[1] = i;
            }
        }

        return result;
    }
}
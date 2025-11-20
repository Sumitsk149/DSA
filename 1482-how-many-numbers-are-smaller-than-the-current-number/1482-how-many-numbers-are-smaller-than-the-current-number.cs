public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) 
    {
        var sortedNums = nums.OrderBy(x => x).ToArray();
        var dict = new Dictionary<int, int>();

        int counter = 0;
        for(int i = 0; i < sortedNums.Length; i++)
        {
            if(i == 0)
            {
                dict.Add(sortedNums[i], counter);
            }
            if(i > 0 )
            {
                counter++;
                if(sortedNums[i-1] != sortedNums[i])
                {
                    dict.Add(sortedNums[i], counter);
                }
            }
        }

        for(int i = 0; i < nums.Length; i++)
        {
            sortedNums[i] = dict[nums[i]];
        }

        return sortedNums;
    }
}
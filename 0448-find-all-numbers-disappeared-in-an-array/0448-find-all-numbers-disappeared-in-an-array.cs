public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) 
    {
        int i = 0;
        List<int> result = new List<int>();
        while(i < nums.Length)
        {
            var currNum = nums[i];
            if(currNum != (i + 1))
            {
                if(nums[currNum - 1] != currNum)
                {
                    swap(currNum - 1, i , nums);
                }
                else
                {
                    i++;
                }
            }
            else
            {
                i++;
            }
        }

        for(int j = 0; j < nums.Length; j++)
        {
            Console.WriteLine(nums[j]);
            if(nums[j] != (j + 1))
            {
                result.Add(j + 1);
            }
        }

        return result;
    }

    public void swap(int i, int j, int[] nums)
    {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
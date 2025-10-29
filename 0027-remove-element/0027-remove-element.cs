public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int i = 0;
        int k = nums.Length - 1;

        while(i < k)
        {
            if(nums[i] == val && nums[k] != val)
            {
                swap(nums, i, k);
                i++;
                k--;
            }
            else if(nums[i] == val && nums[k] == val)
            {
                k--;
            }
            else
            {
                i++;
            }
        }

        int count = 0;
        foreach(var num in nums)
        {
            if(num != val)
            {
                count++;
            }
        }

        return count;
    }

    public void swap(int[] nums, int i, int k) 
    {
        int temp = nums[i];
        nums[i] = nums[k];
        nums[k] = temp;
    }
}
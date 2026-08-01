public class Solution 
{
    public void SortColors(int[] nums) 
    {
        int low = 0;
        int mid = 0;
        int high = nums.Length - 1;

        while(mid <= high)
        {
            if(nums[mid] == 0)
            {
                Swap(mid, low, nums);
                low++;
                mid++;
            }
            else if(nums[mid] == 2)
            {
                Swap(mid, high, nums);
                high--;
            }
            else if(nums[mid] == 1)
            {
                mid++;
            }
        }
    }

    public void Swap(int i, int j, int[] nums)
    {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
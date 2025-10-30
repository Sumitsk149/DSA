public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        //Optmised with less variable declaration
        int k = 0;
        foreach(var num in nums)
        {
            if(k < 2 || num != nums[k - 2])
            {
                nums[k] = num;
                k++;
            }
        }
        return k;
    }
}
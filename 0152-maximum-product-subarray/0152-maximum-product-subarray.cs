public class Solution 
{
    public int MaxProduct(int[] nums) 
    {
        //Solving this using prefix and suffix scan.

        int result = nums[0];
        int prefix = 1;
        int suffix = 1;

        int len = nums.Length - 1;
        for(int i = 0; i <= len; i++)
        {
            prefix = (prefix == 0 ? 1 : prefix) * nums[i];
            suffix = (suffix == 0 ? 1 : suffix) * nums[len - i];

            result = Math.Max(result, Math.Max(prefix, suffix));
        }

        return result;
    }
}
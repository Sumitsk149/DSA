public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        int[] result = new int[nums.Length];
        int pointer = right;

        while(left <= right)
        {
            var leftSquare = nums[left] * nums[left];
            var rightSquare = nums[right] * nums[right];
            if(leftSquare <= rightSquare)
            {
                result[pointer] = rightSquare;
                right--;
            }
            else
            {
                result[pointer] = leftSquare;
                left++;
            }
            pointer--;
        }

        return result;
    }
}
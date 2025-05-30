public class Solution
{
    public int MaxSum(int[] nums)
    {
        int result = -1;
        int[] maxByDigit = new int[10]; // Highest digit range is 0-9

        foreach (int num in nums)
        {
            int digit = GetHighestDigit(num);

            if (maxByDigit[digit] > 0)
            {
                result = Math.Max(result, maxByDigit[digit] + num);
                maxByDigit[digit] = Math.Max(maxByDigit[digit], num);
            }
            else
            {
                maxByDigit[digit] = num;
            }
        }

        return result;
    }

    private int GetHighestDigit(int num)
    {
        int maxDigit = 0;
        while (num > 0 && maxDigit < 9)
        {
            maxDigit = Math.Max(maxDigit, num % 10);
            num /= 10;
        }
        return maxDigit;
    }
}

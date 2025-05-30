public class Solution {
    public int MaxSum(int[] nums) {

        int result = -1;

        Dictionary<int, int> hashMap = new Dictionary<int, int>();

        foreach(var num in nums)
        {
            int digit = GetHighestDigit(num);
            if(hashMap.ContainsKey(digit))
            {
                result = Math.Max(result, (hashMap[digit] + num));
                if(num > hashMap[digit])
                {
                    hashMap[digit] = num;
                }
            }
            else
            {
                hashMap.Add(digit, num);
            }
        }

        return result;
        
    }

    public int GetHighestDigit(int num)
    {
        int maxDigit = 0;

        while(num > 0)
        {
            int digit = num % 10;
            maxDigit = Math.Max(maxDigit, digit);
            num = num / 10;
            if(maxDigit == 9)
            {
                break;
            }
        }
        
        return maxDigit;
    }
}
public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int minValue = prices[0];
        int maxValue = prices[0];
        int result = 0;
        
        for(int i = 1; i < prices.Length; i++)
        {
            if(prices[i] > minValue)
            {
                if(prices[i] > maxValue)
                {
                    maxValue = prices[i];
                    int diff = maxValue - minValue;
                    if(diff > result)
                    {
                        result = diff;
                    }
                }                
            }
            else
            {
                minValue = prices[i];
                maxValue = prices[i];
            }
        }
        
        return result;
    }
}
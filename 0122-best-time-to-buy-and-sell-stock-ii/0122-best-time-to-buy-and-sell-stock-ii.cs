public class Solution {
    public int MaxProfit(int[] prices) {
        
        int currentPrice = prices[0];
        int totalProfit = 0;
        
        for(int i = 1; i < prices.Length; i++)
        {
            if(prices[i] > currentPrice)
            {
                if(i == prices.Length - 1)
                {
                    totalProfit += prices[i] - currentPrice;
                }
                else
                {
                    if(prices[i] > prices[i+1])
                    {
                        totalProfit += prices[i] - currentPrice;
                        currentPrice = prices[i+1];
                    }
                }                
            }
            else
            {
                currentPrice = prices[i];
            }
        }

        return totalProfit;        
    }
}
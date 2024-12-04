public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        int max = candies[0];
        for(int i = 1; i < candies.Length; i++)
        {
            max = Math.Max(candies[i], max);
        }

        List<bool> result = new List<bool>();
        for(int i = 0; i < candies.Length; i++)
        {
            if(candies[i] + extraCandies >= max)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }                
        }
        return result;
    }
}
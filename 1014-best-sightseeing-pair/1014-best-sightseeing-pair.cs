public class Solution 
{
    public int MaxScoreSightseeingPair(int[] values) 
    {
        int result = 0;
        int max = values[0];

        for(int i = 1; i < values.Length; i++)
        {
            result = Math.Max(result, max + values[i] - i);

            max = Math.Max(max, values[i] + i);
        }

        return result;
    }
}
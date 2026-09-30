public class Solution 
{
    public int MaxScoreSightseeingPair(int[] values) 
    {
        // Best values[i] + i seen so far
        int maxLeftScore = values[0] + 0;
        int maxScore = 0;

        for (int j = 1; j < values.Length; j++) {
            // Best score using current j and the best left partner
            maxScore = Math.Max(maxScore, maxLeftScore + values[j] - j);
            // Update best left partner for future j's
            maxLeftScore = Math.Max(maxLeftScore, values[j] + j);
        }

        return maxScore;
    }
}
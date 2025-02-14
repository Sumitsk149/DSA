public class Solution {
    public int LengthOfLongestSubstring(string s) {        
        int maxCount = 0;
        HashSet<char> hs = new HashSet<char>();
        
        int i = 0;
        int j = 0;

        while (i <= j && j < s.Length)
        {
            if(hs.Add(s[j]))
            {
                j++;
            }
            else
            {
                maxCount = Math.Max(j-i, maxCount);
                hs.Remove(s[i]);
                i++;
            }
        }

        return Math.Max(j-i, maxCount);        
    }
}
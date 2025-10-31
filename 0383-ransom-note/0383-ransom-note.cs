public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) 
    {
        var dict = new Dictionary<char, int>();
        
        foreach(var ch in magazine)
        {
            if (!dict.ContainsKey(ch))
                dict[ch] = 0;

            dict[ch]++;
        }

        foreach(var ch in ransomNote)
        {
            if (!dict.ContainsKey(ch) || dict[ch] == 0)
                return false;

            dict[ch]--;
        }

        return true;
    }
}
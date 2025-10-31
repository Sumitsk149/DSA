public class Solution {
    public bool WordPattern(string pattern, string s) 
    {
        var dict = new Dictionary<char, string>();

        var words = s.Split(" ");

        if (pattern.Length != words.Length)
            return false;

        for(int i = 0; i < pattern.Length; i++)
        {
            if(dict.TryGetValue(pattern[i], out string val))
            {
                if(val != words[i])
                    return false;
            }
            else
            {
                if(dict.ContainsValue(words[i]))
                    return false;
                dict[pattern[i]] = words[i];
            }
        }

        return true;
    }
}
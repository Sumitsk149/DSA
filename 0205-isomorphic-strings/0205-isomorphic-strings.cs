public class Solution {
    public bool IsIsomorphic(string s, string t) 
    {
        var dict = new Dictionary<char, char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(dict.TryGetValue(s[i], out char cc))
            {
                if(cc != t[i])
                    return false;
            }
            else
            {
                if(dict.ContainsValue(t[i]))
                    return false;

                dict[s[i]] = t[i];
            }
        }

        return true;
    }
}
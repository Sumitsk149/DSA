public class Solution {
    public int PartitionString(string s) {
        HashSet<char> hs = new();
        int count = 1;
        foreach(var ch in s)
        {
            if(!hs.Add(ch))
            {
                count++;
                hs = new();
                hs.Add(ch);
            }
        }

        return count;
        
    }
}
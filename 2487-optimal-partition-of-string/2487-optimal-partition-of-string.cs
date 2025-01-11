public class Solution {
    public int PartitionString(string s) {
        var set = new HashSet<char>();
        var count = 1;

        foreach (var c in s) {
            if (set.Contains(c)) {
                set.Clear();
                count++;
            }
            set.Add(c);
        }

        return count;
    }
}
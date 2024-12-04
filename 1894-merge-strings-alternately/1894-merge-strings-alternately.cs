public class Solution {
    public string MergeAlternately(string word1, string word2) {

        int len1 = word1.Length;
        int len2 = word2.Length;
        int maxLength = Math.Max(len1, len2);

        StringBuilder sb = new();

        for(int i = 0; i < maxLength; i++)
        {
            if(i < len1)
                sb.Append(word1[i]);
            
            if(i < len2)
                sb.Append(word2[i]);
        }

        return sb.ToString();
        
    }
}
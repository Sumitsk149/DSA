public class Solution {
    public string ReverseWords(string s) {
        List<String> words = new List<String>();

        StringBuilder sb = new();
        foreach(var ch in s)
        {
            if(char.IsWhiteSpace(ch))
            {
                if(sb.Length > 0)
                {
                    words.Add(sb.ToString());
                    sb = new();
                }
            }
            else
            { 
                sb.Append(ch);                               
            }
        }

        if(sb.Length > 0)
        {
            words.Add(sb.ToString());
            sb = new();
        }


        for(int i = words.Count - 1; i >= 0; i--)
        {
            sb.Append(words[i]);
            if(i != 0)
                sb.Append(" ");
        }

        return sb.ToString();
    }
}
public class Solution {
    public string ReverseWords(string s) {
        StringBuilder sb = new();

        var sArray = s.Split(" ");

        for(int i = sArray.Length - 1; i >= 0; i--)
        {
            if (!string.IsNullOrEmpty(sArray[i]))
            {
                if(sb.Length > 0)
                {
                    sb.Append($" {sArray[i]}");
                }
                else
                {
                    sb.Append(sArray[i]);
                }
            }
        }

        return sb.ToString();
    }
}
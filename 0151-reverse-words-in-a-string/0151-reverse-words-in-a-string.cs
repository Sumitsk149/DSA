public class Solution
{
    public string ReverseWords(string s)
    {
        StringBuilder sb = new();
        int end = -1;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (!char.IsWhiteSpace(s[i]))
            {
                if (end == -1)
                {
                    end = i;
                }

                // If we're at the start of the string or previous char is whitespace, we found a word boundary
                if (i == 0 || char.IsWhiteSpace(s[i - 1]))
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(' ');
                    }
                    sb.Append(s.Substring(i, end - i + 1));
                    end = -1;
                }
            }
        }

        return sb.ToString();
    }
}

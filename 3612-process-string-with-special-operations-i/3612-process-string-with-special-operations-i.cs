public class Solution
{
    public string ProcessStr(string s)
    {
        var result = new StringBuilder();

        foreach (var ch in s)
        {
            switch (ch)
            {
                case '*': // Remove last char
                    if (result.Length > 0)
                        result.Length--;
                    break;

                case '#': // Duplicate efficiently
                    if (result.Length > 0)
                    {
                        int len = result.Length;
                        result.EnsureCapacity(result.Length + len);
                        for (int i = 0; i < len; i++)
                            result.Append(result[i]);
                    }
                    break;

                case '%': // Reverse in place
                    if (result.Length > 0)
                        Reverse(result);
                    break;

                default: // Normal append
                    result.Append(ch);
                    break;
            }
        }

        return result.ToString();
    }

    private void Reverse(StringBuilder sb)
    {
        int left = 0, right = sb.Length - 1;
        while (left < right)
        {
            char temp = sb[left];
            sb[left] = sb[right];
            sb[right] = temp;
            left++;
            right--;
        }
    }
}

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

                case '#': // Duplicate
                    if (result.Length > 0)
                    {
                        int len = result.Length;
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

    private void Reverse(StringBuilder result)
    {
        int left = 0, right = result.Length - 1;
        while (left < right)
        {
            char temp = result[left];
            result[left] = result[right];
            result[right] = temp;
            left++;
            right--;
        }
    }
}
public class Solution {
    public string ProcessStr(string s) {

        var result = new StringBuilder();
        foreach(var ch in s)
        {
            if(ch == '*')
            {
                Remove(ch, result);
            }
            else if(ch == '#')
            {
                Duplicate(result);
            }
            else if(ch == '%')
            {
                result = Reverse(result);
            }
            else
            {
                result.Append(ch);
            }
        }

        return result.ToString();
    }

    public void Remove(char ch, StringBuilder result)
    {
        if(result.Length > 0)
        {
            result.Length--;
        }
    }

    public void Duplicate(StringBuilder result)
    {
        if(result.Length > 0)
        {
            result.Append(result.ToString());
        }
    }

    public StringBuilder Reverse(StringBuilder result)
    {        
        if(result.Length > 0)
        {
            var output = new StringBuilder();

            for (int i = result.Length - 1; i >= 0; i--)
            {
                output.Append(result[i]);
            }

            return output;
        }

        return new StringBuilder();
    }
}
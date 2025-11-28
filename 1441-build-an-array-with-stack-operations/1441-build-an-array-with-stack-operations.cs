public class Solution {
    public IList<string> BuildArray(int[] target, int n) 
    {
        var result = new List<string>();
        var index = 0;

        for(int i = 1; i <= n; i++)
        {
            if(target[index] == i)
            {
                result.Add("Push");
                index++;
                if(target.Length == index)
                    return result;
            }
            else
            {
                result.Add("Push");
                result.Add("Pop");
            }
        }

        return result;

    }
}
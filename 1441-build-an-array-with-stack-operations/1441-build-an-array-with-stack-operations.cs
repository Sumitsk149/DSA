public class Solution {
    public IList<string> BuildArray(int[] target, int n) 
    {
        var result = new List<string>();
        var count = 0;

        for(int i = 1; i <= n; i++)
        {
            result.Add("Push");
            count++;

            if(target[count - 1] != i)
            {
                result.Add("Pop");
                count--;
            }

            if(target.Length == count && target[target.Length - 1] == i)
            {
                return result;
            }            
        }

        return result;
    }
}
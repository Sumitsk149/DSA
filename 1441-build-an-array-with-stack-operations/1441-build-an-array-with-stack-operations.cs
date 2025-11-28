public class Solution {
    public IList<string> BuildArray(int[] target, int n) 
    {
        var stack = new Stack<int>();
        var result = new List<string>();
        var curr = 0;

        for(int i = 1; i <= n; i++)
        {
            if(target.Length == stack.Count && stack.Peek() == target[target.Length - 1])
            {
                return result;
            }

            if(stack.Count > 0 )
            {
                if(curr > 0 && stack.Peek() != target[curr - 1])
                {
                    stack.Pop();
                    result.Add("Pop");
                }
                else if (curr == 0 && stack.Peek() != target[curr])
                {
                    stack.Pop();
                    result.Add("Pop");
                }
            }

            stack.Push(i);
            result.Add("Push");
            
            if(i == target[curr])
            {
                curr++;
            }  
        }

        return result;

    }
}
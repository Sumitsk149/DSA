public class Solution {
    public int EvalRPN(string[] tokens) {

        Stack<int> stack = new Stack<int>();

        foreach(var token in tokens)
        {
            if(int.TryParse(token, out int num))
            {
                stack.Push(num);
            }
            else
            {
                int num2 = stack.Pop();
                int num1 = stack.Pop();

                stack.Push(token switch 
                { 
                    "+" => num1 + num2, 
                    "-" => num1 - num2, 
                    "*" => num1 * num2, 
                    "/" => num1 / num2, 
                    _ => throw new InvalidOperationException("Unknown operator")
                });
            }
        }

        return stack.Pop();        
    }
}
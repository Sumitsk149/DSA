public class MinStack {

    Stack<(int value, int min)> stack = new();

    public MinStack() 
    {      
    }
    
    public void Push(int val) 
    {
        int min = stack.Count == 0 ? val : Math.Min(val, stack.Peek().min);
        stack.Push((val, min));
    }
    
    public void Pop() 
    {
        stack.Pop();
    }
    
    public int Top() 
    {
        return stack.Peek().value;
    }
    
    public int GetMin() 
    {
        return stack.Peek().min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
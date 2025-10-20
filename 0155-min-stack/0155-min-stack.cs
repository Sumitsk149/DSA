public class MinStack {

    Stack<(int value, int min)> stack;
    int min = 0;
    int top = -1;

    public MinStack() 
    {
        stack = new Stack<(int value, int min)>();        
    }
    
    public void Push(int val) 
    {
        if(top == -1)
        {
            min = val;
        }
        else if(val < min)
        {
            min = val;
        }
        
        stack.Push((val, min));
        top++;
    }
    
    public void Pop() 
    {
        stack.Pop();
        top--;
        if(top != -1)
        {
            min = GetMin();
        }
    }
    
    public int Top() 
    {
        var topVal = stack.Peek();
        return topVal.value;
    }
    
    public int GetMin() 
    {
        var topVal = stack.Peek();
        return topVal.min;
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
public class MinStack {
    Stack<int> s = new Stack<int>();
    Stack<int> minstack = new Stack<int>();

    public MinStack() {
    }
    
    public void Push(int val) {
        if(minstack.Count ==0){
            minstack.Push(val);
        }
        else if(val <= minstack.Peek()){
            minstack.Push(val);
        }
        

        s.Push(val);
    }
    
    public void Pop() {
        if(s.Peek() == minstack.Peek()) minstack.Pop();
        s.Pop();
    }
    
    public int Top() {
        return s.Peek();
    }
    
    public int GetMin() {
        return minstack.Peek();
    }
}

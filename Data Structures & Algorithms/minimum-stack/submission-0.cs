public class MinStack {
    Stack<int> s = new Stack<int>();

    public MinStack() {
    }
    
    public void Push(int val) {
        s.Push(val);
    }
    
    public void Pop() {
        s.Pop();
    }
    
    public int Top() {
        return s.Peek();
    }
    
    public int GetMin() {
        int min =int.MaxValue;
        foreach(int i in s){
            if(i < min) min = i;
        }
        return min;
    }
}

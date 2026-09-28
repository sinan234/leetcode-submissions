public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];

        Stack<int> s = new Stack<int>();

        for(int right=0;right<temperatures.Length; right++){
            
            
            while (s.Count > 0 && temperatures[s.Peek()] < temperatures[right]){
               res[s.Peek()] = right - s.Peek();

                s.Pop();
            }

            s.Push(right);

        
        }

        return res;
        
    }
}

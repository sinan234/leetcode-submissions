public class Solution {
    public int EvalRPN(string[] tokens) {
        HashSet<string> ops = new HashSet<string> {"+","-","*", "/"};
        Stack<int> s = new Stack<int>();

        int result = 0;
        for(int i = 0; i<tokens.Length;i++){
            if(!ops.Contains(tokens[i])){
                s.Push(Convert.ToInt32(tokens[i]));
            }
            else{
                if(s.Count > 0){
                    int second = s.Pop();
                    int first = s.Pop();

                    switch(tokens[i]){
                        case "+":
                                result = first+second;
                                break;
                        case "-":
                                result = first - second;
                                break;
                        case "*":
                                result = first  * second;
                                break;
                        case "/":
                                result = first/ second;
                                break;
                        default:
                            break;
                    }
                    s.Push(result);
                }
            }
        }

        return s.Peek();
        
    }
}

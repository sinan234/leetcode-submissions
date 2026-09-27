public class Solution {
    public bool IsValid(string s) {
    if(s.Length ==1) return false;

    Dictionary<char, char> d = new Dictionary<char, char>
    {
        { '[', ']' },
        { '{', '}' },
        { '(', ')' }
    };

        Stack<char> stack = new Stack<char>();

        for(int i = 0; i<s.Length; i++){
            if(d.ContainsKey(s[i])){
                stack.Push(s[i]);
            }
            else if(stack.Count >0){
                if(d[stack.Pop()] != s[i]){
                    return false;
                }
            }
            else{
                return false;
            }
        }
    
        return stack.Count >0 ? false : true;
    }
}

public class Solution {  
    List<string> res = new List<string>();

    public List<string> GenerateParenthesis(int n) {
        BackTrack(0,0, n, "");
        return res;
    }

    public void BackTrack(int open, int close, int n, string current){
         if(current.Length == 2*n){
            res.Add(current);
            return;
        }
        if(open < n){
            BackTrack(open + 1, close, n, current + "(");        }
         if (close< open){
            BackTrack(open, close + 1, n, current + ")");
        }

       
    }
}

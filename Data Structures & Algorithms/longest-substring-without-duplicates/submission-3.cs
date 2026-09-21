public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max= 0 ;
        List<char> res = new List<char>();
        for(int i = 0; i<s.Length;i++){
            if(!res.Contains(s[i])){
                res.Add(s[i]);
            }

            else{
               res.RemoveRange(0,res.IndexOf(s[i])+1);
               res.Add(s[i]);
            }

            if(res.Count() > max) max = res.Count();

        }

        return max;
    }
}

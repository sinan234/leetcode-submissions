public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length < t.Length) return string.Empty;

        Dictionary<char, int> targetdict = new Dictionary<char, int>();

        Dictionary<char, int> windowdict = new Dictionary<char, int>();

        List<string> l = new List<string>();
        
        int left =0;
        int bestlength=int.MaxValue;
        int bestleft =0;
        int required =0;
        int formed =0;


        for(int i=0;i<t.Length; i++){
            if(!targetdict.ContainsKey(t[i])){
                targetdict[t[i]] =1;
                required++;
            }
            else{
                targetdict[t[i]] += 1;
            }

        }

        for(int right = 0;right<s.Length; right++){
            if(!windowdict.ContainsKey(s[right])){
                windowdict[s[right]] =1;
            }
            else{
                windowdict[s[right]] += 1;
            }

            if(targetdict.ContainsKey(s[right]) && windowdict[s[right]] == targetdict[s[right]]){
                formed++;
            }

            while(formed == required){
                if(bestlength > right - left+1){
                    bestlength = right - left+1;
                    bestleft = left;
                }

                windowdict[s[left]] --;

                if(targetdict.ContainsKey(s[left]) && windowdict[s[left]] < targetdict[s[left]]){
                    formed --;
                }
                left++;
            }
           
        }

        return bestlength == int.MaxValue ? string.Empty : s.Substring(bestleft, bestlength);
    }
}

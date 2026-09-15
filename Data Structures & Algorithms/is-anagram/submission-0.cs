public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char,int> d = new  Dictionary<char,int>();
        foreach(char i in s){
            if(d.ContainsKey(i)){
                d[i]+=1;
            }
            else{
                d[i]=1;
            }
        }

        foreach(char i in t){
            if(d.ContainsKey(i)){
                d[i]-=1; 
            }
        }

        foreach(var i in d){
            if(i.Value != 0){
                return false;
            }
        }

        return true;
    }
}

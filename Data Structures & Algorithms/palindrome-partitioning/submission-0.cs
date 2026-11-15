public class Solution {

    List<List<string>> res = new List<List<string>>();
    List<string> current = new List<string>();

    public List<List<string>> Partition(string s) {
        if(string.IsNullOrEmpty(s)){
            return new List<List<string>>();
        }

        BackTrack(0,s);
        return res;
    }

    public void BackTrack(int start, string s){
        if(start == s.Length){
res.Add(new List<string>(current));
            return;
        }

        for(int i =start;i<s.Length;i++){
            string sub = s.Substring(start, i-start +1);

            char[] arr = sub.ToCharArray();
            Array.Reverse(arr);
            string rev = new string(arr);

            if(sub == rev){
                current.Add(sub);
                BackTrack(i +1, s);
                current.RemoveAt(current.Count -1);
            }
        }
    }
}

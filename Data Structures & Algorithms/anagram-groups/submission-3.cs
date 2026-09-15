public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> res = new List<List<string>> ();
        Dictionary<string, int> d = new  Dictionary<string, int>();
        for(int i=0;i<strs.Length;i++){
            char[] word = strs[i].ToCharArray();
            Array.Sort(word);
            string sortedWord = new string(word);
            if(d.ContainsKey(sortedWord)){
                int index = d[sortedWord];
                res[index].Add(strs[i]);
            }
            else{
                d[sortedWord] = res.Count();
                res.Add(new List<string> {strs[i]});
            }
        }
        return res;
    }
}

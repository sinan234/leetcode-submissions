public class Solution {

    public string Encode(IList<string> strs) {
        int l = strs.Count();
        string f = "";

        foreach(string i in strs){
                f+= i.Count() +"#" + i;
            
        }
        Console.WriteLine(f);
        return  f; 
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int start = 0;
        while(start<s.Length){

                int hashIndex = s.IndexOf('#', start);
                string sub = s.Substring(start, hashIndex - start);
                int length = Convert.ToInt32(sub);
                res.Add(s.Substring(hashIndex +1, length));
                start = hashIndex + length +1;

                Console.WriteLine($"Start is {start}, length is {length} , sub is {sub}");
            
            
            
        }

        

        return res;
   }
}

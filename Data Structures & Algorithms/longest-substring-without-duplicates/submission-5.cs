public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max =0;
        HashSet<char> h = new HashSet<char>();
        int left = 0;
        for(int i = 0; i<s.Length ;i++){
            while (h.Contains(s[i])) {
                h.Remove(s[left]);
                left++; // Move the left boundary forward
            
            }
            h.Add(s[i]);
            if(h.Count() > max) max = h.Count();
        }

        return max;
    }
}

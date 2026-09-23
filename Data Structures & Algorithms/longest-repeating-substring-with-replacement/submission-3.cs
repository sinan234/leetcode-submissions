public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxlen =0;
        int maxcount =0;
        int left =0;
        int [] count = new int[26];
        
        for(int right =0; right<s.Length;right++){
            int index = s[right] - 'A';
            count[index]++;

            maxcount = Math.Max(maxcount, count[index]);

            int winlength = right - left +1;

            if(winlength - maxcount > k){
                int leftindex = s[left] - 'A';
                count[leftindex] --;

                left++;
            }

            maxlen= Math.Max(maxlen, right-left+1);
        }
        return maxlen;
    }
}

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;
         
         int[] tcount = new int[26];
         int[] wcount = new int[26];
         int left =0;

         for(int i =0;i<s1.Length;i++){
            tcount[s1[i] - 'a'] ++;
         }
        
        for(int right =0;right<s2.Length;right++){
            wcount[s2[right] - 'a'] ++;
       
            if(right-left+1 > s1.Length){
                wcount[s2[left] - 'a'] --;
                left++;
            }

            int k =0;
            int c =0;
            while(k<26)
            {
                if(wcount[k] == tcount[k])
                { 
                    c++;
                }
                k++;
            }
            if(c== 26) return true;
        }
        return false;


    }
}

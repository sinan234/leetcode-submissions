public class Solution {
    public int LongestConsecutive(int[] nums) {
        int res = 0;
        if(nums.Length ==1) return 1;
        if(nums.Length ==0) return 0;

        HashSet<int> h = new HashSet<int>(nums);    
        Console.WriteLine(string.Join(", ", h));  
        int l = 0;
        int max =0;
        for(int i=0; i<nums.Length ;i++){
           if(!h.Contains(nums[i]-1)){
                int j =nums[i];

                while(h.Contains(j)){
                    l++;
                    j++;
                }

                if(l>max) max =l;
           }
            l=0;
        }

        return max;

    }
}

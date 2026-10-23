public class Solution {
    public int SubarraySum(int[] nums, int k) {
Dictionary<int, int> d = new Dictionary<int, int>
{
    { 0, 1 }
};

        if(nums.Length ==0) return 0;

        int res =0;
        int prefix = 0;
        int requiredsum =0;

        for(int i =0; i<nums.Length; i++){
            prefix += nums[i];
            requiredsum = prefix - k;

            Console.WriteLine($"Required sum is {requiredsum}");

            
                if(d.ContainsKey(requiredsum)){
                    res += d[requiredsum];
                }
            

            if(!d.ContainsKey(prefix)){
                d[prefix] = 1;
            }
            else{
                d[prefix]++;
            }
        }

        return res;
    }
}
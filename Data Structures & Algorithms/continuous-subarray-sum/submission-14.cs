public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        if(nums.Length <1) return false;

        int prefix = 0;
        Dictionary<int,int> d = new Dictionary<int,int>{
            {0,-1}
        };
        
        for(int i=0;i<nums.Length;i++){
            prefix += nums[i];
            int balance = (prefix % k);

            Console.WriteLine($"Balance is {balance} and prefix sum is {prefix}");
            
            if(d.ContainsKey(balance)){
                if(i - d[balance] >=2) return true;
            }
            else {
                d[balance] = i;
            }

        }

        return false;
    }
}
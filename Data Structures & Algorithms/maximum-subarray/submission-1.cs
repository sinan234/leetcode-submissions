public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Length ==0) return 0;

        int runningsum = nums[0];
        int max = nums[0];
        
        for(int i =1;i<nums.Length ;i++){
            runningsum+=nums[i];
            if(nums[i] > runningsum){
                runningsum = nums[i];
            }

            max = Math.Max(runningsum, max);
        }

        return max;
    }
}

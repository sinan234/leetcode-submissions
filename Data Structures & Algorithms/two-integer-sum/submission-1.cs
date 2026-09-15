public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0;i<nums.Length-1;i++){
            int b = target  - nums[i];
            for(int j=i+1;j<nums.Length;j++){
                if(i!=j && b== nums[j]){
                    return new int [] {i,j};
                }
            }
        }
        return new int [] {0,0};
    }
}

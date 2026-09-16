public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int [] res = new int [nums.Length];
        int leftprod = 1;
        for(int i =0; i<nums.Length; i++){
            res[i] = leftprod;
            leftprod = leftprod * nums[i];
        }

        int rightprod=1;
        for(int i =nums.Length-1; i>=0 ; i--){
            res[i] = res[i] * rightprod;
            rightprod = rightprod * nums[i];

        }
        return res;
    }
}

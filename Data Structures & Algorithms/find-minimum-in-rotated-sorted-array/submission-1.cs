public class Solution {
    public int FindMin(int[] nums) {
        int low = 0;
        int high = nums.Length - 1;

        while(low < high){
            int mid = low + (high - low)  /2;

            Console.WriteLine($"Mid is {mid}");
            
            if(nums[mid] > nums[high]){
                low = mid +1;
                Console.WriteLine($"Low  is {low}");

            }
            else{
                high = mid;
            }
        }
        return nums[low];
    }
}

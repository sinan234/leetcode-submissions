public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length -1;

        while(low<=high){
            int mid = low + (high - low) / 2;


            if(nums[mid] == target) return mid;

            if(nums[mid] >= nums[low]){
                if((nums[low]<= target && nums[mid] >target) )
                {
                    high = mid -1;
                }
                else{
                    low = mid+1;
                }
            }
            else{
                 if((nums[high]>= target && nums[mid] <target) )
                {
                    low=mid+1;
                }
                else{
                    high = mid-1;
                }
            }
                        Console.WriteLine($"Mid is {mid}, Low is {low}, Hign is {high}");

        }

        return -1;
    }
}

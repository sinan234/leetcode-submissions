public class Solution {
    List<int> current = new List<int>();
    List<List<int>> res = new List<List<int>>();
    int remaining = 0;

    public List<List<int>> CombinationSum(int[] nums, int target) { 
        Sum(nums, 0 , target); 
        return res;   
    }

    private void Sum(int[] nums, int index , int remaining){

        if(remaining == 0){
            res.Add(new List<int>(current));
            return;
        }
        else if(remaining <=0 || index >=nums.Length) return;
         
        current.Add(nums[index]);
        Sum(nums, index, remaining - nums[index]);

        current.RemoveAt(current.Count - 1);

        Sum(nums,index+1, remaining);

    }
}

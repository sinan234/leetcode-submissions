public class Solution {
            List<int> current = new List<int>();
        List<List<int>> res = new   List<List<int>>();
    public List<List<int>> Permute(int[] nums) {

        BackTrack(nums);
        return res;
        
    }

    private void BackTrack(int[]  nums){
        if(current.Count == nums.Length){
            res.Add(new List<int>(current));
            return;
        }

        for(int i =0;i<nums.Length;i++){
            if(current.Contains(nums[i])){
                continue;
            }
            else{
                current.Add(nums[i]);
            }

            BackTrack(nums);
                        current.RemoveAt(current.Count - 1);
        }
    }
}

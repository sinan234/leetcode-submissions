public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        List<int> current = new List<int>();
        BackTrack(0,nums, current, res);
        return res;
    }

    public void BackTrack(int start, int[] nums, List<int> current, List<List<int>> res){
        res.Add(new List<int>(current));
        for(int i =start; i<nums.Length;i++){
            current.Add(nums[i]);
            BackTrack(i+1, nums,current,res);
            current.RemoveAt(current.Count-1);
        }
    }
}

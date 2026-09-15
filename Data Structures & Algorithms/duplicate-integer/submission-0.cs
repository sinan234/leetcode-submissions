public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> d = new HashSet<int>();
        foreach(int i in nums){
            if(!d.Contains(i)){
                d.Add(i);
            }
            else{
                return true;
            }
        }
        return false;
    }
}
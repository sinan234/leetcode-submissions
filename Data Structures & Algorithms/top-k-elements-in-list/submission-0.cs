public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> d = new Dictionary<int,int>();
        foreach(int num in nums){
            if(d.ContainsKey(num)){
                d[num]+=1;
            }
            else{
                d[num]=1;
            }
        }
        
        var dict = d.OrderByDescending(i => i.Value);
        int [] res = new int[k];
        int i =0;
        foreach(var item in dict){
            if(i<k){
                res[i] = item.Key;
            }
            i++;
        }
        return res;
    }
}

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int[] count = new int[26];
        List<int> res= new List<int>();
        int left =0;
        LinkedList <int> deque = new LinkedList<int>();

        for(int right=0; right<nums.Length;right++){

            while(deque.Count>0 && nums[deque.Last.Value] < nums[right]){
                deque.RemoveLast();
            }   
                            deque.AddLast(right);


            if(right-left+1 == k){
                res.Add(nums[deque.First.Value]);

                left++;
                if(deque.First.Value < left){
                    deque.RemoveFirst();
                }
            }
        }

        return res.ToArray();
    }
}

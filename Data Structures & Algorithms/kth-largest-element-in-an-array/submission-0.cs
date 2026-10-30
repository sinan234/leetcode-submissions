public class Solution {
    public int FindKthLargest(int[] nums, int k) {
                PriorityQueue<int, int> maxHeap =
    new PriorityQueue<int, int>(
        Comparer<int>.Create((a, b) => b.CompareTo(a))
    );

        foreach(int num in nums){
            maxHeap.Enqueue(num,num);
        }

        int i =1;
        while(i < k && maxHeap.Count >0){
      maxHeap.Dequeue();

            i++;
        }
        
        return maxHeap.Count > 0 ? maxHeap.Dequeue() :-1;
        
    }
}

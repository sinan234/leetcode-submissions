public class KthLargest {
    PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
    private readonly int k;

    public KthLargest(int k, int[] nums) {
                this.k =k;

        foreach(int num in nums){
            Add(num);
        }

    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);

        if (minHeap.Count > k)
        {
            minHeap.Dequeue();
        }

        return minHeap.Peek();
    }
}

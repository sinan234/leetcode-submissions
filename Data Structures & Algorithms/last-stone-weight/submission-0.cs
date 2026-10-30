public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> maxHeap =
    new PriorityQueue<int, int>(
        Comparer<int>.Create((a, b) => b.CompareTo(a))
    );

        foreach(int i in stones){
            maxHeap.Enqueue(i , i);
        }
        int k=0;

        while(maxHeap.Count > 1){
            int x = maxHeap.Dequeue();
            int y =  maxHeap.Dequeue();

             if (x != y)
            {
                maxHeap.Enqueue(x - y, x - y);
            }
        }

        return maxHeap.Count == 0 ? 0 : maxHeap.Dequeue();
    }
}

public class MedianFinder {
    PriorityQueue<int,int> min = new PriorityQueue<int,int>();
    PriorityQueue<int,int> max = new PriorityQueue<int,int>(
        Comparer<int>.Create((a,b) => b.CompareTo(a))
    );


    public MedianFinder() {
        
    }
    
    public void AddNum(int num) {

            max.Enqueue(num,num);
            int largest = max.Dequeue();
            min.Enqueue(largest,largest);

            if(min.Count > max.Count){
                int second = min.Dequeue();
                max.Enqueue(second,second);
            }
    }
    
    public double FindMedian() {
        if(max.Count == min.Count +1){
            return max.Peek();
        }
        else{
            double res = ((double)max.Peek()+(double)min.Peek()) /2;
            return res;
        }
        return -1;
    }
}

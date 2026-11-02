public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        PriorityQueue<int,int> p = new PriorityQueue<int,int> (Comparer<int>.Create((a,b) => b.CompareTo(a)));

        int [] arr = new int [26];
        
        foreach(char task in tasks){
            arr[task - 'A']++;
        }

        foreach(int i in arr){
            if(i > 0){
                p.Enqueue(i, i);
            }
        }

        Queue<( int remaining,int availableAt)> q = new();
        int time =0;

        while(q.Count > 0 || p.Count >0){
            time ++;

            if(q.Count > 0 && q.Peek().availableAt <= time){
                var task = q.Dequeue();
                p.Enqueue(task.remaining, task.remaining);
            }

            if(p.Count > 0){
                int remaining = p.Dequeue();
                remaining --;

                               if (remaining > 0)
                {
                    q.Enqueue(
                        (remaining, time + n + 1));
                }
            }
        }

        return time;
    }
}

public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],double> p = new PriorityQueue<int[],double>();
        for(int j =0; j<points.Length;j++){
            double distance = Math.Pow(points[j][0],2) + Math.Pow(points[j][1],2);

            p.Enqueue(points[j], distance);
        }

        int i =0;
        int[][] res = new int[k][];
        while(i < k){
            var a = p.Dequeue();
            res[i] = a;
            i++;
        }
        return res;
    }
}

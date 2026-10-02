public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Stack<float> s = new Stack<float>();
        int count = 0;
        Array.Sort(position, speed);

        Array.Reverse(position);
        Array.Reverse(speed);

        for(int i=0; i< position.Length ; i++){
            float dis = target - position[i];
            float time = dis /speed[i] ;

            if(s.Count == 0){
                s.Push(time);
                count++;
                continue;
            }
            else if (s.Peek() < time){
                count++;
                s.Push(time);
            }
        }

        return count;
    }
}

public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {

        int low = 1;
        int high = piles.Max();
     
        while(low <= high){
            int mid = low + (high - low) / 2;
            
            Console.WriteLine($"Mid is {mid}");
            int current = 0;

            for(int i =0; i<piles.Length; i++){
                current = current + (piles[i] + mid - 1 ) / mid;
            }

            Console.WriteLine($"Current is {current}");


            if(current <= h){
                high = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        
        return low;

    }
}

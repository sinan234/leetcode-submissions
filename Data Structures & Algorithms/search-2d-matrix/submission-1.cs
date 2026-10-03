public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        int low = 0;
        int high = matrix.Length - 1;

        while(low<=high){
            int mid = low + (high -low) /2;
            Console.WriteLine($"Mid is {mid}");
            int[] midarray = matrix[mid];

            foreach(int i in midarray){
                if(i==target){
                    return true;
                }
            }

            if(midarray[0] < target){
                low = mid +1;
            }
            else{
                high = mid-1;
            }
        }
        
        return false;
    }
}

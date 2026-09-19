public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;
        int res = 0;

        int left =0;
        int right = heights.Length -1;

        while(left< right){
            int height = Math.Min(heights[left],heights[right]);
            int width = right - left;
             res= width * height;

            if(res>max) max = res;
            
            if(heights[left] < heights[right]){
                left++;
            }
            else{
                right--;
            }
        }

        return max;
    }
}

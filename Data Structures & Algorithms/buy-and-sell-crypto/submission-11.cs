public class Solution {
    public int MaxProfit(int[] prices) {
        int max  = 0;
        int p =0;

        int left =0;
        int right = prices.Length ;

        int minprice =prices[left];

        while(left < right){
            minprice = Math.Min(minprice, prices[left]);
            Console.WriteLine(minprice);
            p = prices[left] - minprice;

            left++;

            if(p>max) max =p;
        }

        return max;
    }
}

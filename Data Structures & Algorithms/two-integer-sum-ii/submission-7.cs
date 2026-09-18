public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] res = new int[2];

        Dictionary<int, int> d = new Dictionary<int, int>();

        for(int i=0;i<numbers.Length;i++){
            if(d.ContainsKey(target-numbers[i])){
                res[0]= d[target-numbers[i]]+1;
                res[1] = i+1;

            }
            else{
                if(!d.ContainsKey(numbers[i])){
            d[numbers[i]] = i;

            }
            }
        }
        // int left =0;

        // while (left < numbers.Length-1){
        //     int right = left +1;

        //     while(right < numbers.Length ){
        //         if(numbers[left] + numbers[right] == target){
        //             res[0] = left +1;
        //             res[1] = right +1;
        //         }

        //         right ++;
        //     }

        //     left++;
        // }

        return res;
    }
}

public class Solution {
    public bool IsPalindrome(string s) {
        string rev ="";
        string og ="";
        foreach(char i in s){
            if(char.IsLetterOrDigit(i)){
                og += char.ToLower(i);
            }
        }
        for(int i =og.Length-1; i>=0; i--){
            rev+=og[i];
        }
        Console.WriteLine($"String is {og} and rev is {rev}");
        return rev == og;
    }
}

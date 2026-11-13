public class Solution {
    List<string> res = new List<string>();
Dictionary<char, List<char>> d = new Dictionary<char, List<char>>{
            {'2', new List<char>{'a','b','c'}},
            {'3', new List<char>{'d','e','f'}},
            {'4', new List<char>{'g','h','i'}},
            {'5', new List<char>{'j','k','l'}},
            {'6', new List<char>{'m','n','o'}},
            {'7', new List<char>{'p','q','r','s'}},
            {'8', new List<char>{'t','u','v'}},
            {'9', new List<char>{'w','x','y','z'}}
        };
    public List<string> LetterCombinations(string digits) {
        if(string.IsNullOrEmpty(digits)) return new List<string>();
        BackTrack(0,"",digits);
        return res;
    }

    public void BackTrack(int index, string current, string digits){
        if(index >= digits.Length){
            res.Add(current);
            return;
        }

        var items = d[digits[index]];

        foreach(char item in items){
            BackTrack(index+1,current+item, digits);
        }

    }
}

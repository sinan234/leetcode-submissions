public class Solution {
    bool res = false;
    public bool Exist(char[][] board, string word) {
        int row = board.Length;
        int col = board[0].Length;

        for(int i=0;i<row; i++){
            for(int j =0;j<col; j++){
                if(BackTrack(board, word, i, j,0 )) return true;
            }
        }
         return false;
    }

    public bool BackTrack(char[][] board, string word, int row, int col, int index){
        if(index == word.Length) return true;

        if(row < 0 || col <0 || row >=board.Length || col>=board[0].Length ||board[row][col] != word[index] ){
            return false;
        }

        char temp = board[row][col];
        board[row][col] ='#';

        bool found = 
            BackTrack(board, word, row-1 , col, index+1) ||
            BackTrack(board,word, row+1 , col, index+1) ||
            BackTrack(board,word, row , col-1, index+1) ||
            BackTrack(board,word, row , col+1, index+1);

        board[row][col] = temp;
        return found;
    }
}

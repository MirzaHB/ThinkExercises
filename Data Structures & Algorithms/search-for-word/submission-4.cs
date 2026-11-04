public class Solution {
    public bool Exist(char[][] board, string word) {
        var directions = new List<(int,int)>{(-1,0),(1,0),(0,-1),(0,1)};
        HashSet<(int,int)> set = new();
        bool find(int r, int c, int i){
            if(i==word.Length) return true;
            foreach(var dir in directions){
                r = dir.Item1 + r;
                c = dir.Item2 + c;
                if(!(set.Contains((r,c)) || Math.Min(r,c)<0 || r>=board.Length || c>= board[0].Length))
                    if(board[r][c]==word[i]){
                        set.Add((r,c));
                        if(find(r,c,i+1)) return true;
                        set.Remove((r,c));
                    }
                r-=dir.Item1;
                c-=dir.Item2;
            }
            return false;
        }

        for(int r=0; r<board.Length; r++){
            for(int c=0; c<board[0].Length; c++){
                if(board[r][c]==word[0]){
                    set.Add((r,c));
                    if(find(r,c, 1)) return true;
                    set.Remove((r,c));
                }                    
            }
        }
        return false;
    }
}

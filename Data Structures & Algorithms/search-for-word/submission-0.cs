public class Solution {
    public bool Exist(char[][] board, string word) {
        int row = board.Length;
        int col = board[0].Length;
        HashSet<(int,int)> set = new();
        Queue<(int,int)> q = new();
        var neighbours = new List<(int,int)>{(-1,0), (1,0), (0,-1), (0,1)};
        for(int r=0; r<row; r++){
            for(int c=0; c<col; c++){
                if(board[r][c]==word[0]){
                    set.Add((r,c));
                    if(dfs(0,r,c)) return true;
                    set.Remove((r,c));
                }
            }
        }
        
        bool dfs(int index, int cR, int cC){
            if(index == word.Length) return true;
            if(board[cR][cC] == word[index]){
                foreach(var (x,y) in neighbours){
                    int nr = cR + x;
                    int nc = cC + y;
                    if(index+1==word.Length) return true;
                    if(Math.Min(nr,nc)<0 || nr>=row || nc>=col || set.Contains((nr,nc)) || board[nr][nc]!= word[index+1]) continue;
                    set.Add((nr,nc));
                    if(dfs(index+1, nr, nc)) return true;
                    set.Remove((nr,nc));
                }
            }
            return false;
        }
        return false;
    }
}

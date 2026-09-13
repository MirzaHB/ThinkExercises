public class Solution {
    public bool Exist(char[][] board, string word) {
        int row = board.Length;
        int col = board[0].Length;
        var set = new HashSet<(int,int)>();
        var neighbours = new List<(int,int)>{(-1,0), (1,0), (0,-1), (0,1)};

        bool dfs(int r, int c, int i){
            if(i==word.Length-1){
                if(board[r][c]==word[word.Length-1])return true;
                return false;
            }

            if(board[r][c]!=word[i]) return false;
            
            foreach(var n in neighbours){
                var nr = r + n.Item1;
                var nc = c + n.Item2;
                if(Math.Min(nr,nc)<0 || nr>=row || nc >=col || set.Contains((nr,nc))) continue;

                set.Add((nr,nc));
                var found = dfs(nr,nc,i+1);
                if(found) return true;
                set.Remove((nr,nc));
            }
            return false;
        }

        for(int r=0; r<row; r++){
            for(int c=0; c<col; c++){
                if(word[0] == board[r][c]){
                    set.Add((r,c));
                    if(dfs(r,c,0)) return true;
                    set.Remove((r,c));
                }
            }
        }
        return false;
    }
}

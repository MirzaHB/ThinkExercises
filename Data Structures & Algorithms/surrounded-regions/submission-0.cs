public class Solution {
    public void Solve(char[][] board) {
        Queue<(int,int)> q = new();
        HashSet<(int,int)> visited = new();
        int row = board.Length;
        int col = board[0].Length;

        for(int c=0; c<col; c++){
            if(board[0][c]=='O'){
                q.Enqueue((0,c));
                visited.Add((0,c));
            }
            if(board[row-1][c]=='O'){
                q.Enqueue((row-1,c));
                visited.Add((row-1,c));
            }
        }

        for(int r=0;r<row;r++){
            if(board[r][0]=='O'){
                q.Enqueue((r,0));
                visited.Add((r,0));
            }
            if(board[r][col-1]=='O'){
                q.Enqueue((r,col-1));
                visited.Add((r,col-1));
            }
        }
        var neighbors = new List<(int dr, int dc)>{(-1,0), (1,0), (0,-1), (0,1)};
        while(q.Any()){
            int qlen = q.Count;
            for(int i=0;i<qlen;i++){
                var (r,c) = q.Dequeue();
                foreach(var dir in neighbors){
                    int nr = r+dir.dr;
                    int nc = c+dir.dc;

                    if(Math.Min(nr,nc)<0 || nr>=row || nc>=col || visited.Contains((nr,nc)) || board[nr][nc]!='O') continue;
                    q.Enqueue((nr,nc));
                    visited.Add((nr,nc));
                }
            }
        }

        for(int r=0;r<row;r++){
            for(int c=0;c<col;c++){
                if(!visited.Contains((r,c)) && board[r][c]=='O')
                    board[r][c]='X';
            }
        }
    }
}

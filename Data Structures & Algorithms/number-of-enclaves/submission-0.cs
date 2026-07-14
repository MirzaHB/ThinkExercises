public class Solution {
    public int NumEnclaves(int[][] grid) {
        HashSet<(int,int)> visited = new();
        Queue<(int,int)> q = new();
        int row = grid.Length;
        int col = grid[0].Length;

        for(int i=0; i<row; i++){
            if(grid[i][0]==1 && !visited.Contains((i,0))){
                q.Enqueue((i,0));
                visited.Add((i,0));
            }
            if(grid[i][col-1]==1 && !visited.Contains((i,col-1))) {
                q.Enqueue((i,col-1));
                visited.Add((i,col-1));
            }
        }
        for(int i=0; i<col; i++){
            if(grid[0][i]==1 && !visited.Contains((0,i))) {
                q.Enqueue((0,i));
                visited.Add((0,i));
            }
            if(grid[row-1][i]==1 && !visited.Contains((row-1,i))) {
                q.Enqueue((row-1,i));
                visited.Add((row-1,i));
            }
        }
        var neighbours = new List<(int,int)>{(-1,0), (1,0), (0,-1), (0,1)};
        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var (r,c) = q.Dequeue();
                foreach(var (x,y) in neighbours){
                    int nr = r+x;
                    int nc = c+y;
                    if(Math.Min(nr,nc)<0 || nr>=row || nc>=col || visited.Contains((nr,nc)) || grid[nr][nc]!=1) continue;
                    q.Enqueue((nr,nc));
                    visited.Add((nr,nc));
                }
            }
        }

        int ans =0;
        for(int r=0; r<row; r++){
            for(int c=0; c<col; c++){
                if(grid[r][c]==1 && !visited.Contains((r,c))) ans+=1;
            }
        }
        return ans;
    }
}
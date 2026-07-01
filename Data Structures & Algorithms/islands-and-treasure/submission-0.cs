public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        HashSet<(int,int)> visited = new();
        Queue<(int,int)> q = new();

        var row = grid.Length;
        var col = grid[0].Length;
        int inf = 2147483647;
        for(int r=0; r<row; r++){
            for(int c=0; c<col; c++){
                if(grid[r][c]==0) {q.Enqueue((r,c)); visited.Add((r,c));}
            }
        }
        if(q.Count==0) return;

        var neighbors = new List<(int dr,int dc)>{(0,-1), (0,1), (-1,0), (1,0)};
        int dist = 0;
        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var (x,y) = q.Dequeue();
                if(grid[x][y]==inf){
                    grid[x][y] = dist;
                }

                foreach(var dir in neighbors){
                    int nx = x + dir.dr;
                    int ny = y + dir.dc;
                    
                    if(Math.Min(nx,ny)<0 || nx>=row || ny>=col || visited.Contains((nx,ny)) || grid[nx][ny]!=inf) continue;

                    q.Enqueue((nx,ny));
                    visited.Add((nx,ny));
                }
            }
            dist +=1;
        }
    }
}

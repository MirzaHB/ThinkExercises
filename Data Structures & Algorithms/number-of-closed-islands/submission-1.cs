public class Solution {
    public int ClosedIsland(int[][] grid) {
        HashSet<(int,int)> set = new();
        Queue<(int,int)> q = new();
        int ans = 0;
        // travel perimeter of grid
        for(int r=0; r<grid.Length; r++){
            if(grid[r][0]==0) bfs(r,0);
            if(grid[r][grid[0].Length-1]==0) bfs(r, grid[0].Length-1);
        }
        for(int c=0; c<grid[0].Length; c++){
            if(grid[0][c]==0) bfs(0,c);
            if(grid[grid.Length-1][c]==0) bfs(grid.Length-1, c);
        }

        void bfs(int row, int col){
            if(set.Contains((row,col))) return;
            set.Add((row,col));
            q.Enqueue((row,col));
            var directions = new List<(int, int)>{(-1,0), (1,0), (0,-1), (0,1)};
            while(q.Any()){
                var qlen = q.Count;
                for(int i=0; i<qlen; i++){
                    var (r,c) = q.Dequeue();
                    foreach(var dir in directions){
                        var nr = r+dir.Item1;
                        var nc = c+dir.Item2;
                        if(Math.Min(nr,nc)<0 || nr>=grid.Length || nc>=grid[0].Length || set.Contains((nr,nc)) || grid[nr][nc]!=0) continue;
                        q.Enqueue((nr,nc));
                        set.Add((nr,nc));
                    }
                }
            }
        }

        for(int r=0; r<grid.Length; r++)
            for(int c=0; c<grid[0].Length; c++)
                if(grid[r][c]==0 && !set.Contains((r,c))) {ans++;bfs(r,c);}
        
        return ans;
    }
}

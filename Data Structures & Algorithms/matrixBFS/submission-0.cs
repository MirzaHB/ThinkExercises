public class Solution {
    public int ShortestPath(int[][] grid) {
        return bfs(grid);
    }

    public int bfs(int[][] grid){
        HashSet<(int,int)> set = new();
        Queue<(int,int)> q = new();
        if(grid[0][0] == 1) return -1;
        q.Enqueue((0,0));

        int ans = 0;
        var row = grid.Length-1;
        var col = grid[0].Length-1;
        int[][] neighbours = { new[] {0, 1}, new[] {0, -1}, new[] {1, 0}, new[] {-1, 0} };

        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen;i++){
                (int r,int c) = q.Dequeue();
                
                if(r==row && c==col) return ans;
                foreach(var dir in neighbours){
                    int nr = r + dir[0];
                    int nc = c + dir[1];
                    if(Math.Min(nr,nc)<0 || nr>row || nc>col || set.Contains((nr,nc)) || grid[nr][nc]==1) continue;
                    set.Add((r+dir[0],c+dir[1]));
                    q.Enqueue((nr,nc));
                }
            }
            ans+=1;
        }
        return -1;
    }
}

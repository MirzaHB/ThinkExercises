public class Solution {
    public int MaxDistance(int[][] grid) {
        int distance = -1;
        HashSet<(int, int)> set = new();
        Queue<(int, int)> q = new();
        for(int r=0; r<grid.Length; r++)
            for(int c=0; c<grid[0].Length; c++)
                if(grid[r][c]==1) {
                    q.Enqueue((r,c));
                    set.Add((r,c));
                }
        var directions = new List<(int,int)>{(-1,0),(0,-1),(0,1),(1,0)};
        int rows = grid.Length-1;
        int cols = grid[0].Length-1;
        var boolie = false;
        while(q.Any()){
            distance++;
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var (r,c) = q.Dequeue();
                foreach(var dir in directions){                    
                    int nr = r + dir.Item1;
                    int nc = c + dir.Item2;
                    if(Math.Min(nr,nc)<0 || nr>rows || nc>cols || set.Contains((nr,nc)) || grid[nr][nc]==1) continue;
                    boolie = true;
                    set.Add((nr,nc));
                    q.Enqueue((nr,nc));
                }
            }
        }
        return boolie ? distance : -1;
    }
}

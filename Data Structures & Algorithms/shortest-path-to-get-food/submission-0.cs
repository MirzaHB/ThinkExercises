public class Solution {
    public int GetFood(char[][] grid) {
        HashSet<(int, int)> visited = new();
        Queue<(int,int)> q = new();
        int rows = grid.Length-1;
        int cols = grid[0].Length-1;
        
        for(int r=0; r<=rows; r++)
            for(int c=0; c<=cols; c++)
                if(grid[r][c]=='*'){
                    q.Enqueue((r,c));
                    visited.Add((r,c));
                }
        var directions = new List<(int,int)>{(-1,0),(1,0),(0,-1),(0,1)};
        int distance = 0;
        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var (r,c) = q.Dequeue();
                if(grid[r][c]=='#') return distance;
                foreach(var dir in directions){
                    int nr = r+dir.Item1;
                    int nc = c+dir.Item2;
                    if(Math.Min(nr,nc)<0 || nr >rows || nc>cols || visited.Contains((nr,nc)) || grid[nr][nc]=='X') continue;
                    q.Enqueue((nr,nc));
                    visited.Add((nr,nc));
                }
            }
            distance++;
        }
        return -1;
    }
}

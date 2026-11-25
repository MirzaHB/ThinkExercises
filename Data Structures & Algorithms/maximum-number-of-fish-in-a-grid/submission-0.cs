public class Solution {
    public int FindMaxFish(int[][] grid) {
        int ans = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;
        HashSet<(int,int)> set = new();

        int bfs(int r, int c){
            int curr = 0;
            set.Add((r,c));
            Queue<(int,int)> q = new();
            q.Enqueue((r,c));
            var directions = new List<(int,int)>{(-1,0),(1,0),(0,-1), (0,1)};
            while(q.Any()){
                var qlen = q.Count;
                for(int i=0; i<qlen; i++){
                    var (rcell, ccell) = q.Dequeue();
                    curr += grid[rcell][ccell];
                    foreach(var dir in directions){
                        int nr = rcell+dir.Item1;
                        int nc = ccell+dir.Item2;
                        if(Math.Min(nr,nc)<0 || nr>=rows || nc>=cols || set.Contains((nr,nc)) || grid[nr][nc]==0) continue;
                        set.Add((nr,nc));
                        q.Enqueue((nr,nc));
                    }
                }
            }
            return curr;
        }

        for(int r=0; r<rows; r++){
            for(int c=0; c<cols; c++){
                if(grid[r][c]>0 && !set.Contains((r,c))) ans = Math.Max(ans, bfs(r,c));
            }
        }
        return ans;
    }
}

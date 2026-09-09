public class Solution {
    public int OrangesRotting(int[][] grid) {
        var q = new Queue<(int,int)>();
        var set = new HashSet<(int,int)>();
        int row = grid.Length;
        int col = grid[0].Length;
        int ans = 0;
        int fresh = 0;
        var directions = new List<(int,int)>{(-1,0), (1,0), (0,-1), (0,1)};

        for(int r=0;r<row;r++)
            for(int c=0;c<col;c++){
                if(grid[r][c]==2) {q.Enqueue((r,c));set.Add((r,c));}
                if(grid[r][c]==1) fresh+=1;
            }
        
        while(q.Any()){
            var qlen = q.Count;
            var currFresh = fresh;
            for(int i=0; i<qlen;i++){
                var (r,c) = q.Dequeue();
                foreach(var dir in directions){
                    var (dr, dc) = dir;
                    int nr = r+dr;
                    int nc = c+dc;
                    if(Math.Min(nr,nc)<0 || nr>=row || nc>=col || set.Contains((nr,nc)) || grid[nr][nc]!=1) continue;
                    fresh-=1;
                    set.Add((nr,nc));
                    q.Enqueue((nr,nc));
                }
            }
            if(currFresh!=fresh) ans+=1;
        }
        return fresh>0 ? -1: ans;
    }
}

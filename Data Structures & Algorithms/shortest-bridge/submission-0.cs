public class Solution {
    public int ShortestBridge(int[][] grid) {
        HashSet<(int,int)> island1 = new();
        Queue<(int,int)> q = new();
        var row = grid.Length;
        var col = grid[0].Length;
        var neighbours = new List<(int,int)>{(-1,0),(1,0),(0,-1),(0,1)};

        (int x, int y) getIsland(){
            for(int r=0; r<row; r++){
                for(int c=0; c<col; c++){
                    if(grid[r][c]==1){
                        return (r,c);
                    }
                }
            }
            return (0,0);
        }
        void bfs(int r, int c){
            while(q.Any()){
                var qlen = q.Count;
                for(int i=0; i<qlen; i++){
                    var (cr,cc) = q.Dequeue();
                    foreach(var (dr,dc) in neighbours){
                        int nr = cr+dr;
                        int nc = cc+dc;
                        if(Math.Min(nr,nc)<0 || nr>=row || nc>=col || island1.Contains((nr,nc)) || grid[nr][nc]!=1) continue;
                        q.Enqueue((nr,nc));
                        island1.Add((nr,nc));
                    }
                }
            }
        }
        var (zx,zy) = getIsland();
        q.Enqueue((zx, zy));
        island1.Add((zx, zy));
        bfs(zx,zy);

        foreach(var (r,c) in island1){
            q.Enqueue((r,c));
        }
        int currAns = 0;
        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var (currR, currC) = q.Dequeue();
                foreach(var (dr,dc) in neighbours){
                    int nr = currR + dr;
                    int nc = currC + dc;
                    if(Math.Min(nr,nc)<0 || nr>=row || nc>=col || island1.Contains((nr,nc))) continue;
                    if(grid[nr][nc] == 1) return currAns;
                    island1.Add((nr,nc));
                    q.Enqueue((nr,nc));
                }
            }
            currAns+=1;
        }
        return currAns;
    }
}
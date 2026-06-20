public class Solution {
    public int OrangesRotting(int[][] grid) {
        return bfs(grid);
    }

    public int bfs(int[][] grid){
        HashSet<(int,int)> set = new();
        Queue<(int,int)> q = new();
        var freshOranges = 0;
        var row = grid.Length-1;
        var col = grid[0].Length-1;
        var ans = 0;
        for(int r=0; r<=row; r++){
            for(int c=0; c<=col; c++){
                if(grid[r][c]==1) freshOranges++;
                if(grid[r][c]==2) q.Enqueue((r,c));
            }
        }
        var neighbours = new List<(int, int)> {(-1, 0), (1, 0), (0,-1), (0,1)};
        if(freshOranges==0) return 0;
        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                (int r, int c) = q.Dequeue();

                foreach(var (x, y) in neighbours){
                    int nr = r+x;
                    int nc = c+y;
                    if(Math.Min(nr,nc)<0 || nr>row || nc>col || set.Contains((nr,nc)) || grid[nr][nc] != 1) continue;
                    q.Enqueue((nr,nc));
                    set.Add((nr,nc));
                    freshOranges-=1;
                }
            }
            ans+=1;
        }
        return freshOranges!=0 ? -1 : ans-1;
    }
}

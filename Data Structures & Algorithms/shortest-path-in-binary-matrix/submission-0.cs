public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
      return bfs(grid);  
    }
    public int bfs(int[][] grid){
        HashSet<(int,int)> set = new();
        Queue<(int,int)> q = new();
        var ans = 1;
        var len = grid.Length-1;
        if(grid[0][0]==1 || grid[len][len]==1) return -1;
        q.Enqueue((0,0));
        set.Add((0,0));
        var neighbours = new List<(int,int)> {(-1,-1),(-1,0),(1,1),(0,-1),(0,1),(1,-1),(1,0),(1,1)};
        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                (int r, int c) = q.Dequeue();
                if(r==len && c==len) return ans;
                foreach(var (x,y) in neighbours){
                    int nr = r+x;
                    int nc = c+y;
                    if(Math.Min(nr,nc)<0 || nr>len || nc>len || set.Contains((nr,nc)) || grid[nr][nc]==1) continue;
                    q.Enqueue((nr,nc));
                    set.Add((nr,nc));
                }
            }
            ans+=1;
        }
        return -1;
    }
}
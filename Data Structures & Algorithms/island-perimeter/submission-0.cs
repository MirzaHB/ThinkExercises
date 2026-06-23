public class Solution {
    public int IslandPerimeter(int[][] grid) {
      //check if neighbours of every land square is water or edge or land
      // if water or edge then perimeter++
        for(int r=0; r<grid.Length; r++){
            for(int c=0; c<grid[0].Length; c++){
                if(grid[r][c]==1) return bfs(grid,r,c);
            }
        }
        return 4;
    }

    public int bfs(int[][] grid, int r, int c){
        var ans=0;
        var row = grid.Length-1;
        var col = grid[0].Length-1;
        HashSet<(int,int)> set = new();
        Queue<(int,int)> q = new();
        q.Enqueue((r,c));
        set.Add((r,c));

        var neighbours = new List<(int,int)>{(-1,0),(1,0),(0,-1),(0,1)};
        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                (int currR, int currC) = q.Dequeue();
                //edges
                if(currR==0) ans+=1;
                if(currR==row) ans+=1;
                if(currC==0) ans+=1;
                if(currC==col) ans+=1;

                // surrounding water + q more land neighbours
                foreach(var (x,y) in neighbours){
                    int nr = currR+x;
                    int nc = currC+y;
                    if(Math.Min(nr,nc)>=0 && nr<=row && nc<=col && grid[nr][nc]==0) ans+=1;
                    if(Math.Min(nr,nc)>=0 && nr<=row && nc<=col && grid[nr][nc]==1 && !set.Contains((nr,nc))){
                        q.Enqueue((nr,nc));
                        set.Add((nr,nc));
                    }
                }
            }
        }
        return ans;
    }
}
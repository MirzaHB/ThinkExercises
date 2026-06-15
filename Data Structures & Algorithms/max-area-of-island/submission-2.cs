public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        HashSet<(int,int)> set = new();
        int ans = 0;

        for(int r=0; r<grid.Length; r++){
            for(int c=0; c<grid[0].Length; c++){
                if(!set.Contains((r,c)) && grid[r][c]==1){
                    var before = set.Count;
                    dfs(grid,r,c,set);
                    ans = Math.Max(ans, set.Count - before);
                }
            }
        }
        return ans;
    }

    public void dfs(int[][] grid, int r, int c,  HashSet<(int,int)> set){
        int row = grid.Length-1;
        int col = grid[0].Length-1;

        if(set.Contains((r,c)) || Math.Min(r,c)<0 || r>row || c>col || grid[r][c]==0) return;

        set.Add((r,c));
        dfs(grid,r+1,c,set);
        dfs(grid,r-1,c,set);
        dfs(grid,r,c+1,set);
        dfs(grid,r,c-1,set);
    }
}

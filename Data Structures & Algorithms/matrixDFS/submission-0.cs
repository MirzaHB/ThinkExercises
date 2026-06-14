public class Solution {
    public int CountPaths(int[][] grid) {
        HashSet<(int,int)> set = new();
        return dfs(grid,0,0,set);
    }
    public int dfs(int [][] grid, int r, int c, HashSet<(int,int)> set){
        var ROW = grid.Length -1;
        var COL = grid[0].Length -1;
        if(set.Contains((r,c))) return 0;

        if(Math.Min(r,c)<0 || r>ROW || c>COL || grid[r][c]==1) return 0;

        if(r==ROW && c==COL) return 1;

        set.Add((r,c));
        var count = 0;

        count += dfs(grid,r+1,c,set);
        count += dfs(grid,r-1,c,set);
        count += dfs(grid,r,c+1,set);
        count += dfs(grid,r,c-1,set);

        set.Remove((r,c));
        return count;
    }
}

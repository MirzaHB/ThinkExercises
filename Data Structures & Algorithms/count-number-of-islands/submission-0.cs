public class Solution {
    public int NumIslands(char[][] grid) {
        HashSet<(int,int)> set = new();
        var count = 0;

        for(int r=0; r<grid.Length; r++){
            for(int c=0; c<grid[0].Length; c++){
                if(!set.Contains((r,c)) && grid[r][c]=='1'){
                    count+=1;
                    dfs(grid,r,c,set);
                }
            }
        }
        return count;
    }

    public void dfs(char[][] grid, int r, int c, HashSet<(int,int)> set){
        int row = grid.Length-1;
        int col = grid[0].Length-1;

        if(Math.Min(r,c)<0 || r>row || c>col || set.Contains((r,c)) || grid[r][c]!='1') return;

        set.Add((r,c));
        dfs(grid,r+1,c,set);
        dfs(grid,r-1,c,set);
        dfs(grid,r,c+1,set);
        dfs(grid,r,c-1,set);
    }
}

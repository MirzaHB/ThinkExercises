public class Solution {
    public int CountServers(int[][] grid) {
        int[] rows = new int[grid.Length];
        int[] cols = new int[grid[0].Length];

        for(int r=0; r<grid.Length; r++){
            for(int c=0; c<grid[0].Length; c++){
                if(grid[r][c]==1){
                    rows[r]++;
                    cols[c]++;
                }
            }
        }

        int ans = 0;
        for(int r=0;r<grid.Length;r++){
            for(int c=0; c<grid[0].Length; c++){
                if(grid[r][c]==1)
                    if(rows[r]>1 || cols[c]>1) ans++;
            }
        }
        return ans;
    }
}
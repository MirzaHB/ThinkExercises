public class Solution {
    public int og;
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        og = image[sr][sc];
        dfs(image, sr, sc, color, new HashSet<(int,int)>());
        return image;
    }
    public void dfs(int[][] image, int sr, int sc, int color, HashSet<(int,int)> set){
        int row = image.Length-1;
        int col = image[0].Length-1;

        if(Math.Min(sr,sc)<0 || sr>row || sc>col || image[sr][sc]!=og || set.Contains((sr,sc))) return;
        set.Add((sr,sc));
        image[sr][sc]= color;
        dfs(image, sr+1,sc,color, set);
        dfs(image, sr-1,sc,color, set);
        dfs(image,sr, sc+1,color, set);
        dfs(image,sr, sc-1,color, set);
        return;
    }
}
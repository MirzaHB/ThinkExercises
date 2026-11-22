public class Solution {
    public bool HasPath(int[][] maze, int[] start, int[] destination) {
        int rows = maze.Length;
        int cols = maze[0].Length;
        bool[,] visited = new bool[rows,cols];
        var directions = new List<(int,int)>{(-1,0), (1,0), (0,-1), (0,1)};

        bool dfs(int r,int c){
            if(r==destination[0] && c==destination[1]) return true;

            if(visited[r,c]) return false;
            visited[r,c] = true;
            foreach(var dir in directions){
                int ir = r;
                int ic = c;
                while(Math.Min(ir+dir.Item1,ic+dir.Item2)>=0
                 && ir+dir.Item1<rows && ic+dir.Item2<cols 
                 && maze[ir+dir.Item1][ic+dir.Item2]==0){
                    ir +=dir.Item1;
                    ic +=dir.Item2;
                }
                if(dfs(ir,ic)) return true;
            }
            return false;
        }
        return dfs(start[0],start[1]);
    }
}

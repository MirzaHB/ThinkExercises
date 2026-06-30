public class Solution {
    public int CountComponents(int n, int[][] edges) {
        Dictionary<int, List<int>> neighbors = new();
        HashSet<int> visited = new();
        int ans =0;
        for(int i=0; i<n; i++) neighbors[i] = new List<int>();

        foreach(var edge in edges){
            neighbors[edge[0]].Add(edge[1]);
            neighbors[edge[1]].Add(edge[0]);
        }

        for(int i=0; i<n; i++){
            if(!visited.Contains(i)){
                ans+=1;
                dfs(i, neighbors, visited);
            }
        }
        return ans;
    }

    public void dfs(int x, Dictionary<int, List<int>> neighbors, HashSet<int> visited){
        if(visited.Contains(x)) return;

        visited.Add(x);
        foreach(var n in neighbors[x]){
            dfs(n, neighbors, visited);
        }
    }
}

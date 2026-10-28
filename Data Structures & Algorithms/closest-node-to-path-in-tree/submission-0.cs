public class Solution {
    public int[] ClosestNode(int n, int[][] edges, int[][] query) {
        var ans = new int[query.Length];
        HashSet<int> path = new();
        Dictionary<int, List<int>> adj = new();
        for(int j=0; j<n;j++) adj[j] = new List<int>();
        foreach(var edge in edges){
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }
        int i=0;
        foreach(var q in query){
            path.Clear();
            List<int> pathList = dfs(q[0], q[1], adj);
            foreach(var node in pathList) path.Add(node);
            var nearest = bfs(path, q[2], adj);
            ans[i]=nearest;
            i++;
        }
        return ans;
    }
    public int bfs(HashSet<int> path, int node, Dictionary<int, List<int>> adj){
        if(path.Contains(node)) return node;
        HashSet<int> visited = new();
        Queue<int> q = new();
        visited.Add(node);
        q.Enqueue(node);
        while(q.Count>0){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                int curr = q.Dequeue();
                if(path.Contains(curr)) return curr;
                foreach(var neighbour in adj[curr]){
                    if(visited.Contains(neighbour)) continue;
                    visited.Add(neighbour);
                    q.Enqueue(neighbour);
                }
            }
        }
        return -1;
    }
    public List<int> dfs(int a, int b, Dictionary<int, List<int>> adj){
        HashSet<int> visited = new();
        if(a==b) return [b];
        (bool,List<int>) recurse(int x, int z, List<int> curr){
            if(x == z) { curr.Add(z); return (true, curr);}
            foreach(var nei in adj[x]){
                if(visited.Contains(nei)) continue;
                visited.Add(nei);
                curr.Add(x);
                var (found, ans) = recurse(nei, z, curr);
                if(found) return (true, ans);
                curr.RemoveAt(curr.Count-1);
                visited.Remove(nei);
            }
            return (false, curr);
        }

        visited.Add(a);
        var (boolie, ans) = recurse(a, b, []);
        return ans;
    }
}

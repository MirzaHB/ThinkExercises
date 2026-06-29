public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        if(edges.Length>n-1) return false;
        if(n==1) return true;

        Dictionary<int, List<int>> kids = new();
        for(int i=0; i<n; i++) kids[i] = new List<int>();
        foreach(var edge in edges){
            kids[edge[0]].Add(edge[1]);
            kids[edge[1]].Add(edge[0]);
        }


        Queue<(int,int)> q = new();
        HashSet<int> visited = new();
        q.Enqueue((0,-1));

        while(q.Any()){
            var qlen = q.Count;
            for(int i=0; i<qlen; i++){
                var (curr,parent) = q.Dequeue();
                if(visited.Contains(curr)) return false;
                visited.Add(curr); 

                foreach(var kid in kids[curr]){
                    if(kid != parent){
                       q.Enqueue((kid,curr));
                    }                   
                }
            }
        }
        if(visited.Count!=n) return false;
        return true;
    }
}

public class Solution {
    public int CountComponents(int n, int[][] edges) {
        Dictionary<int, int> par = new();
        Dictionary<int, int> rank = new();
        HashSet<int> set = new();

        foreach(var edge in edges){
            par[edge[0]] = edge[0];
            par[edge[1]] = edge[1];
            rank[edge[0]] = 1;
            rank[edge[1]] = 1;
        }

        int find(int k){
            var p = par[k];
            while(p!=par[p]){
                par[p] = par[par[p]];
                p = par[p];
            }
            return p;
        }

        void union(int k, int m){
            int p1 = find(k);
            int p2 = find(m);

            if(p1==p2) return;
            if(rank[p1]>rank[p2]) {
                par[p2] = p1;
                if(set.Contains(p2)) set.Remove(p2);
            }
            else if(rank[p2] > rank[p1]) {
                par[p1] = p2;
                if(set.Contains(p1)) set.Remove(p1);
            }
            else{
                par[p2] = p1;
                rank[p1] += 1;
                if(set.Contains(p2)) set.Remove(p2);
            }
        }

        for(int i=0; i<n; i++) set.Add(i);
        foreach(var edge in edges){
            union(edge[0], edge[1]);
        }
        return set.Count;
    }
}

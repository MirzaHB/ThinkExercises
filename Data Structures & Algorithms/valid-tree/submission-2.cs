public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        Dictionary<int, int> par = new();
        Dictionary<int, int> rank = new();
        HashSet<int> set = new();

        foreach(var edge in edges){
            par[edge[0]] = edge[0];
            par[edge[1]] = edge[1];
            set.Add(edge[0]);
            set.Add(edge[1]);
            rank[edge[0]] = 1;
            rank[edge[1]] = 1;
        }

        int find(int j){
            var p = par[j];
            while(p != par[p]){
                par[p] = par[par[p]];
                p = par[p];
            }
            return p;
        }

        bool union(int j, int k){
            var p1 = find(j);
            var p2 = find(k);
            if(p1==p2) return false;

            if(rank[p1]>rank[p2]){
                par[p2] = p1;
                set.Remove(p2);
            }
            else if(rank[p2]>rank[p1]){
                par[p1] = p2;
                set.Remove(p1);
            }
            else{
                par[p2] = p1;
                rank[p1] += 1;
                set.Remove(p2);
            }
            return true;
        }
        foreach(var edge in edges){
            var cycle = union(edge[0], edge[1]);
            if(!cycle) return false;
        }
        if(set.Count > 1) return false;
        return true;
    }
}

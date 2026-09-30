public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        Dictionary<int, int> par = new();
        Dictionary<int, int> rank = new();

        foreach(var edge in edges){
            par[edge[0]] = edge[0];
            par[edge[1]] = edge[1];

            rank[edge[0]] = 0;
            rank[edge[1]] = 0;
        }

        int find(int k){
            int p = par[k];
            while(p!=par[p]){
                par[p] = par[par[p]];
                p = par[p];
            }
            return p;
        }

        bool union(int m, int n){
            int p1 = find(m);
            int p2 = find(n);

            if(p1==p2) return false;
            if(rank[p1]>rank[p2]) par[p2] = p1;
            else if(rank[p2]>rank[p1]) par[p1] = p2;
            else{
                par[p2] = p1;
                rank[p1] = rank[p1] + 1;
            }
            return true;
        }
        bool redundant;
        foreach(var edge in edges){
            redundant = union(edge[0], edge[1]);
            if(!redundant) return edge;
        }
        return [0,0];
    }
}

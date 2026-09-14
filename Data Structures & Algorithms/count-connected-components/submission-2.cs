public class Solution {
    public int CountComponents(int n, int[][] edges) {
        int count = 0;
        var set = new HashSet<int>();
        var al = new Dictionary<int, List<int>>();
        foreach(var edge in edges){
            if(!al.ContainsKey(edge[0])) al[edge[0]] = new List<int>();
            if(!al.ContainsKey(edge[1])) al[edge[1]] = new List<int>();
            al[edge[0]].Add(edge[1]);
            al[edge[1]].Add(edge[0]);
        }

        void dfs(int curr){
            if(set.Contains(curr)) return;
            set.Add(curr);
            foreach(var neighbour in al[curr]){
                dfs(neighbour);
            }
        }

        foreach(var (k,v) in al){
            if(!set.Contains(k)){
                count +=1;
                dfs(k);
            }
        }
        count += n-set.Count;
        return count;
    }
}

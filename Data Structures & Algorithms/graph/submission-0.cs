public class Graph {
    public Dictionary<int,HashSet<int>> neighbours;
    public Graph() {
        neighbours = new();
    }

    public void AddEdge(int src, int dst) {
        if(!neighbours.ContainsKey(dst)) neighbours[dst] = new HashSet<int>();
        if(!neighbours.ContainsKey(src)) neighbours[src] = new HashSet<int>();

        neighbours[src].Add(dst);
    }

    public bool RemoveEdge(int src, int dst) {
        if(neighbours.ContainsKey(src)) {
            return neighbours[src].Remove(dst);
        }
        return false;
    }

    public bool HasPath(int src, int dst) {
        HashSet<int> set = new();
        return dfs(src,dst,set);
    }

    public bool dfs(int src, int dst, HashSet<int> set){
        if(src == dst) return true;
        set.Add(src);
        foreach(var dest in neighbours[src]){
            if(!set.Contains(dest)){
                if(dfs(dest,dst,set)) return true;
            }
        }
        return false;
    }
}

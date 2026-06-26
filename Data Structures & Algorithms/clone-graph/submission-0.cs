/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        Dictionary<Node, Node> map = new();
        return dfs(node, map);
    }

    public Node dfs(Node old, Dictionary<Node,Node> map){
        if(old ==null) return null;
        if(map.ContainsKey(old)) return map[old];

        var copy = new Node(old.val);
        map[old] = copy;
        foreach(var neighbor in old.neighbors){
            copy.neighbors.Add(dfs(neighbor,map));
        }
        return copy;
    }
}

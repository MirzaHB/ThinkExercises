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
        var map = new Dictionary<int, Node>();
        Node dfs(Node curr){
            var copy = new Node(curr.val);
            map[curr.val] = copy;
            foreach(var n in curr.neighbors){
                if(map.ContainsKey(n.val))
                    copy.neighbors.Add(map[n.val]);
                else copy.neighbors.Add(dfs(n));
            }
            return copy;
        }
        if(node==null) return null;
        return dfs(node);
    }
}

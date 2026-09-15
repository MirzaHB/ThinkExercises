public class TrieNode{
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public bool wordEnd = false;
}
public class PrefixTree {
    TrieNode root;
    public PrefixTree() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        var curr = root;
        foreach(char c in word){
            if(!curr.children.ContainsKey(c)) curr.children[c] = new TrieNode();
            curr = curr.children[c];
        }
        curr.wordEnd = true;
    }
    
    public bool Search(string word) {
        var curr = root;
        foreach(char c in word){
            if(!curr.children.ContainsKey(c)) return false;
            curr = curr.children[c];
        }
        return curr.wordEnd == true ? true : false;
    }
    
    public bool StartsWith(string prefix) {
                var curr = root;
        foreach(char c in prefix){
            if(!curr.children.ContainsKey(c)) return false;
            curr = curr.children[c];
        }
        return true;
    }
}

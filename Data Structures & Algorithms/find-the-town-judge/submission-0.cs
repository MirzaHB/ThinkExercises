public class Solution {
    public int FindJudge(int n, int[][] trust) {
        var al = new Dictionary<int, HashSet<int>>();

        foreach(var t in trust){
            if(!al.ContainsKey(t[0])) al[t[0]] = new HashSet<int>();
            al[t[0]].Add(t[1]);
        }
        int l=1;
        // find l that trusts no one
        for(int r=1; r<n+1; r++){
            if(Trust(l,r)) {
                l=r;
                continue;
            }
        }
        if (al.ContainsKey(l) && al[l].Count > 0) return -1;
        // make sure everyone trusts l
        for(int i=1; i<=n; i++){
            if(i!=l){
                if(!Trust(i,l)) return -1;
            }
        }
        return l;

        bool Trust(int a, int b){
            if(!al.ContainsKey(a)) return false;
            return al[a].Contains(b) ? true : false;
        }
    }
}
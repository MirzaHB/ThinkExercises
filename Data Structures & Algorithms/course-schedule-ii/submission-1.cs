public class Solution {
    public List<int> ans = new();
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        Dictionary<int, List<int>> preReqs = new();
        HashSet<int> rReq = new();
        
        foreach(var course in prerequisites){
            if(!preReqs.ContainsKey(course[0])){
                var list = new List<int>();
                preReqs[course[0]] = list;
            }
            preReqs[course[0]].Add(course[1]);
        }

        for(int i=0;i<numCourses; i++){
            if(rReq.Contains(i)) continue;

            HashSet<int> visited = new();
            if(!dfs(i, preReqs, rReq, visited)) return [];
        }
        return ans.ToArray();
    }
    
    public bool dfs(int course, Dictionary<int, List<int>> preReqs, HashSet<int> rReq, HashSet<int> visited){
        if(visited.Contains(course)) return false;
        if(rReq.Contains(course)) return true;
        if(!preReqs.ContainsKey(course)){
            rReq.Add(course);
            ans.Add(course);
            return true;
        }
        visited.Add(course);
        foreach(var pre in preReqs[course]){
            if(!dfs(pre, preReqs, rReq, visited)) return false;
        }
        visited.Remove(course);
        ans.Add(course);
        rReq.Add(course);
        return true;
    }
}

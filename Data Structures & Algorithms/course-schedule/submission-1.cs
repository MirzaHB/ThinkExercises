public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        // build adj list, loop thru each course, check if course prerReqs can be completed
        Dictionary<int,List<int>> preReqs = new();
        HashSet<int> rReq = new();
        foreach(var courses in prerequisites){
            if(!preReqs.ContainsKey(courses[0])){
                var list = new List<int>();
                preReqs[courses[0]] = list;
            }
            preReqs[courses[0]].Add(courses[1]);
        }

        for(int i=0; i<numCourses; i++){
            if(!rReq.Contains(i)){
                HashSet<int> visited = new();
                if(!dfs(i,preReqs,rReq, visited)) return false;
            }
        }
        return true;
    }

    public bool dfs(int course, Dictionary<int, List<int>> preReqs, HashSet<int> rReq, HashSet<int> visited){
        if(rReq.Contains(course)) return true;
        if(!preReqs.ContainsKey(course)){ 
            rReq.Add(course);
            return true;
        }
        if(visited.Contains(course)) return false;
        visited.Add(course);
        foreach(var pre in preReqs[course]){
            if(!dfs(pre, preReqs, rReq, visited)) return false;
            rReq.Add(pre);
        }
        return true;
    }
}

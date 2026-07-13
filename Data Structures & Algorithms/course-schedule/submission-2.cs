public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        HashSet<int> cr = new();
        HashSet<int> visiting = new();
        Dictionary<int,List<int>> preReqs = new();
        for(int n=0; n<numCourses; n++)
            preReqs[n] = new List<int>();
        
        foreach(var pre in prerequisites){
            preReqs[pre[0]].Add(pre[1]);
        }

        for(int n=0; n<numCourses; n++){
            if(cr.Contains(n)) continue;
            if(!dfs(n)) return false;
        }

        bool dfs(int n){
            if(visiting.Contains(n)) return false;
            if(cr.Contains(n)) return true;
            if(preReqs[n].Count==0){
                cr.Add(n);
                return true;
            }
            visiting.Add(n);
            foreach(int preCourse in preReqs[n]) {                
                if(!dfs(preCourse)) return false;
            }
            visiting.Remove(n);
            cr.Add(n);
            return true;
        }
        return true;
    }
}

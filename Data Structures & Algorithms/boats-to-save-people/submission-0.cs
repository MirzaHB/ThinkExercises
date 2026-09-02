public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        int ans = 0;
        int l= 0;
        int r = people.Length-1;
        Array.Sort(people);

        while(l<=r){
            ans+=1;
            if(limit>=people[r]+people[l]){
                r--;
                l++;
                continue;
            }
            r--;
        }
        return ans;
    }
}
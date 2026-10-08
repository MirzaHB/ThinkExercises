public class Solution {
    public Dictionary<int, int> cache = new();
    public int ClimbStairs(int n) {     
        if(n<=2) return n;
        if(cache.ContainsKey(n)) return cache[n];
        var AnsFromCurrStep = ClimbStairs(n-1) + ClimbStairs(n-2);
        cache[n] = AnsFromCurrStep;
        return cache[n];
    }
}

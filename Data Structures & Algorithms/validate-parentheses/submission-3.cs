public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();
        if(s.Length % 2 !=0) return false;
        foreach(char c in s){
            if(c=='(' || c=='{' || c=='[') stack.Push(c);
            else{
                if(stack.Count == 0) return false;
                if(c==')' && stack.Peek()!='(') return false;
                if(c=='}' && stack.Peek()!='{') return false;
                if(c==']' && stack.Peek()!='[') return false;
                stack.Pop();
            }
        }
        if(stack.Count > 0) return false;
        return true;
    }
}

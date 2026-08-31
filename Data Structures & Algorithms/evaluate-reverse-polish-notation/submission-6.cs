public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new();

        foreach(string c in tokens){
            if(c=="+"){
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(a+b);
            }else if(c=="-"){
                var a = stack.Pop();
                var b = stack.Pop();
                stack.Push(b-a);
            } else if(c=="*"){
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(a*b);
            }else if(c=="/"){
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(a/b);
            }else stack.Push(int.Parse(c));
        }
        return stack.Pop();
    }
}

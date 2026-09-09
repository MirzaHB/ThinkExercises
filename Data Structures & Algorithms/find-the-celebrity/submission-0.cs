/* The Knows API is defined in the parent class Relation.
      bool Knows(int a, int b); */

public class Solution : Relation {
    public int FindCelebrity(int n) {
        int l=0;    // l will always point at the potential celeb
        int r = 1;

        while(r<n){
            if(Knows(l,r)) {
                l=r; // l is not celeb
            }
            r+=1;
        }
        for(int i=0; i<n; i++){
            if(l!=i){
                if(Knows(l,i)==true || Knows(i,l)==false) return -1;
            }
        }
        return l;
    }
}

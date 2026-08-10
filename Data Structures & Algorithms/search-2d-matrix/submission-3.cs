public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rlen = matrix[0].Length-1;
        int lrow = 0;
        int hrow = matrix.Length-1;
        int row =0;
        while(lrow<=hrow){
            int mrow = (lrow+hrow)/2;
            if(target<matrix[mrow][0]) hrow = mrow-1;
            else if(target>matrix[mrow][rlen]) lrow = mrow+1;
            else{
                row = mrow;
                break;
            }
        }

        int l=0;
        int r=rlen;
        while(l<=r){
            int m = (l+r)/2;
            if(matrix[row][m]>target) {
                r=m-1;
                continue;
            }
            if(matrix[row][m]<target) {
                l=m+1;
                continue;
            }
            if(matrix[row][m]==target) return true;
        }
        return false;
    }
}

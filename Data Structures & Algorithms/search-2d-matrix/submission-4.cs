public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int row = 0;
        int l=0;
        int r=matrix.Length-1;
        while(l<=r){
            int m = l+(r-l)/2;
            row = m;
            if(target<matrix[m][0]){
                r = m-1;
            }else if(target>matrix[m][matrix[0].Length-1]){l = m+1;}
            else break;
        }
        int lc = 0;
        int rc = matrix[0].Length-1;
        while(lc<=rc){
            int m = lc + (rc-lc)/2;
            if(target<matrix[row][m]) rc = m-1;
            else if(target>matrix[row][m]) lc = m+1;
            else{
                if(matrix[row][m] == target) return true;
            }
        }
        return false;
    }
}

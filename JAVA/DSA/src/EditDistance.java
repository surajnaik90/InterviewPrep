public class EditDistance {
    public static int[][] dp;
    public static  int minDistance(String A, String B) {

        dp = new int[A.length()+1][B.length()+1];

        int res = calculate(A.length(), B.length(), A, B);

        return res;
    }

    public static int calculate(int m, int n, String A, String B){

        int insertionCost = 0, deletionCost = 0, replaceCost = 0;

        if(m == 0 && n == 0){
            return 0;
        }

        if(m == 0 && n != 0){
            return 1 * n;
        }

        if(n == 0 && m != 0){
            return 1 * m;
        }

        if(A.charAt(m-1) == B.charAt(n-1)) {
            return calculate(m-1,n-1,A,B);
        }

        if(dp[m][n] != 0){
            return dp[m][n];
        }

        insertionCost = 1 + calculate(m, n-1, A, B);

        replaceCost = 1 + calculate(m-1, n-1, A, B);

        deletionCost = 1 + calculate(m-1, n, A, B);

        return dp[m][n] = Math.min(Math.min(insertionCost, replaceCost), deletionCost);
    }
}
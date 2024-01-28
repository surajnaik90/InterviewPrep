import java.util.ArrayList;

public class CoinSumInfinite {

    public static int[][] dp;
    public static int coinchange2(ArrayList<Integer> A, int B) {

        dp = new int[A.size() + 1][B + 1];

        int mod = (int)(Math.pow(10,6) + 7 );

        return coinSum(A.size()-1, B, mod, A);
    }

    //Space Complexity is O(N * B) = Top-down approach
    public static int coinSum(int n, int sum, int mod, ArrayList<Integer> A) {

        int cPicked = 0, cNotPicked = 0;

        if(n < 0) { return 0; }

        if(sum == 0) { return 1; }

        if(dp[n][sum] != 0) { return dp[n][sum]; }

        //Pick the coin (multiple times allowed)
        int rem_sum = sum - A.get(n);
        if(rem_sum >= 0){
            cPicked = coinSum(n, rem_sum, mod, A);
        }

        //Do not pick the coin
        cNotPicked = coinSum(n-1, sum, mod, A);

        return dp[n][sum] = (cPicked + cNotPicked) % mod;
    }
}
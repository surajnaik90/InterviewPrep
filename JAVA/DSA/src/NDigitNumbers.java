public class NDigitNumbers {
    public static int dp[][];
    public static int solve(int A, int B) {

        dp = new int[A+1][B+1];

        int mod = (int)(Math.pow(10,9)+7);

        return ways(A-1, B, mod);
    }

    public static int ways(int index, int rem_sum, int mod){

        Long ways = 0L;

        if(index == 0) {

            if(rem_sum > 0 && rem_sum <= 9) {
                return 1;
            }

            return 0;
        }

        if(dp[index][rem_sum] != 0) {
            return dp[index][rem_sum];
        }

        for(int i = 0; i <= 9; i++) {

            int newSum = rem_sum - i;
            if(newSum >= 0 && index > 0) {

                if(dp[index-1][newSum] == 0){
                    dp[index-1][newSum] = ways(index-1, newSum, mod);
                }
                ways += dp[index-1][newSum];
                ways = ways % mod;
            }
            else {
                break;
            }
        }

        return dp[index][rem_sum] = (int) (ways % mod);
    }
}
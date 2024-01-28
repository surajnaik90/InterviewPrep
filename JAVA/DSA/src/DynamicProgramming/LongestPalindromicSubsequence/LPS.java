package DynamicProgramming.LongestPalindromicSubsequence;

public class LPS {
    public static int[][] dp;
    public static int solve(String A) {

        dp = new int[A.length()+1][A.length()+1];

        return findLPS(0,A.length()-1, A);
    }

    public static int findLPS(int f, int b, String str) {

        if(f >= str.length() || b < 0) { return 0; }

        if(dp[f][b] != 0) { return dp[f][b]; }

        if(str.charAt(f) == str.charAt(b)) {
            return 1 + findLPS(f+1,b-1,str);
        }

        int fPickedCount = findLPS(f+1,b,str);

        int bPickedCount = findLPS(f,b-1,str);

        return dp[f][b] = Math.max(fPickedCount,bPickedCount);
    }
}

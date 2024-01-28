/*
* Given two strings A and B. Find the longest common subsequence ( A sequence which does not need to be contiguous), which is common in both the strings.

You need to return the length of such longest common subsequence.



Problem Constraints
1 <= Length of A, B <= 1005



Input Format
First argument is a string A.
Second argument is a string B.



Output Format
Return an integer denoting the length of the longest common subsequence.



Example Input
Input 1:

 A = "abbcdgf"
 B = "bbadcgf"
Input 2:

 A = "aaaaaa"
 B = "ababab"


Example Output
Output 1:

 5
Output 2:

 3


Example Explanation
Explanation 1:

 The longest common subsequence is "bbcgf", which has a length of 5.
Explanation 2:

 The longest common subsequence is "aaa", which has a length of 3.
*
* */

public class LongestCommonSubsequence {

    public static int[][] dp;
    public static int solve(String A, String B) {

        dp = new int[A.length()+1][B.length()+1];

        return lcs(A.length()-1,B.length()-1,A, B);
    }
    public static int lcs(int m, int n, String A, String B){

        if(m < 0 || n < 0) {
            return 0;
        }

        if(A.charAt(m) == B.charAt(n)){
            return dp[m][n] = 1 + lcs(m-1,n-1,A,B);
        }

        if(dp[m][n] != 0){
            return dp[m][n];
        }

        //Pick the character from A and not from B
        int aPickedCount = lcs(m, n-1, A, B);

        //Pick the character from B and not from A
        int bPickedCount = lcs(m-1, n, A, B);

        return dp[m][n] = Math.max(aPickedCount,bPickedCount);
    }
}

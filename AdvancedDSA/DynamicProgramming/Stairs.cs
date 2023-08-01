/*
You are climbing a staircase and it takes A steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

Return the number of distinct ways modulo 1000000007

Problem Constraints
1 <= A <= 105

Input Format
The first and the only argument contains an integer A, the number of steps.

Output Format
Return an integer, representing the number of ways to reach the top.

Example Input
Input 1:

 A = 2
Input 2:

 A = 3

Example Output
Output 1:

 2
Output 2:

 3

Example Explanation
Explanation 1:

 Distinct ways to reach top: [1, 1], [2].
Explanation 2:

 Distinct ways to reach top: [1 1 1], [1 2], [2 1].
 */

using System.Collections;


public static class Stairs
{
    static int[] dp;
    public static int solve(int A)
    {   
        dp = Enumerable.Repeat(-1, A+1).ToArray();
        return takeSteps(A);
    }

    public static int takeSteps(int remainingSteps)
    {
        if(remainingSteps == 0) {
            return 1;
        }
        else if(remainingSteps < 0) {
            return 0;
        }

        if(dp[remainingSteps] != -1) {
            return dp[remainingSteps];
        }

        long ans = takeSteps(remainingSteps - 1);
        ans = ans % (1000000007);

        ans += takeSteps(remainingSteps - 2);
        ans = ans % (1000000007);

        dp[remainingSteps] = (int)ans;

        return Convert.ToInt32(ans);
    }
}
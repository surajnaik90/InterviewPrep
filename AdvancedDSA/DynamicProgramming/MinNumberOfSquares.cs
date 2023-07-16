/*
Given an integer A. Return minimum count of numbers, sum of whose squares is equal to A.

Problem Constraints
1 <= A <= 105

Input Format
First and only argument is an integer A.

Output Format
Return an integer denoting the minimum count.

Example Input
Input 1:

 A = 6
Input 2:

 A = 5

Example Output
Output 1:

 3
Output 2:

 2

Example Explanation
Explanation 1:

 Possible combinations are : (12 + 12 + 12 + 12 + 12 + 12) and (12 + 12 + 22).
 Minimum count of numbers, sum of whose squares is 6 is 3. 
Explanation 2:

 We can represent 5 using only 2 numbers i.e. 12 + 22 = 5
 */

using System.Collections;


public static class MinNumberOfSquares
{
    static int[] dp;
    public static int solve(int A)
    {
        dp = Enumerable.Repeat(-1, A + 1).ToArray();
        return calculate(A);
    }

    //Top-down approach
    static int calculate(int num)
    {
        int ans = int.MaxValue;

        if (num == 0) {
            return 0;
        }

        if (dp[num] != -1) {
            return dp[num];
        }

        for (int i = 1; i*i <= num; i++) {
            ans = Math.Min(ans, calculate(num - i*i) + 1);
        }

        dp[num] = ans;

        return ans;
    }
}
/*
 You are given a set of coins A. In how many ways can you make sum B assuming you have infinite
amount of each coin in the set.

NOTE:

Coins in set A will be unique. Expected space complexity of this problem is O(B).
The answer can overflow. So, return the answer % (106 + 7).

Problem Constraints
1 <= A <= 500
1 <= A[i] <= 1000
1 <= B <= 50000

Input Format
First argument is an integer array A representing the set.
Second argument is an integer B.

Output Format
Return an integer denoting the number of ways.

Example Input
Input 1:

 A = [1, 2, 3]
 B = 4
Input 2:

 A = [10]
 B = 10


Example Output
Output 1:

 4
Output 2:

 1

Example Explanation
Explanation 1:

 The 4 possible ways are:
 {1, 1, 1, 1}
 {1, 1, 2}
 {2, 2}
 {1, 3} 
Explanation 2:

 There is only 1 way to make sum 10.
 */

namespace MAANG.AdvancedDSA.DynamicProgramming
{
    public class CoinSUmInfinite
    {
        public static int[,] dp;
        public static int solve(List<int> A, int B)
        {
            dp = new int[A.Count + 1, B + 1];

            return maxValues(A.Count - 1, B, A);
        }

        public static int maxValues(int n, int s, List<int> c)
        {
            int tprofit = 0, mod = (int)((Math.Pow(10, 6)) + 7);

            if (n < 0) { return 0; }

            if (dp[n, s] != 0) {
                return dp[n, s];
            }

            //Pick the item (can pick the same item as well)
            if ((s - c[n]) >= 0) {
                tprofit = 1 + maxValues(n, s - c[n], c);
                tprofit %= mod;
            }

            //Don't pick the item
            int fprofit = maxValues(n - 1, s, c);

            int res = (tprofit + fprofit) % (mod);

            return dp[n, s] = res;
        }
    }
}
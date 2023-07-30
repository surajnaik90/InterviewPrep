/*
 Given a rod of length N units and an array A of size N denotes prices that contains prices of all
pieces of size 1 to N.

Find and return the maximum value that can be obtained by cutting up the rod and selling the pieces.

Problem Constraints
1 <= N <= 1000

0 <= A[i] <= 106

Input Format
First and only argument is an integer array A of size N.

Output Format
Return an integer denoting the maximum value that can be obtained by cutting up the rod and selling the pieces.

Example Input
Input 1:

 A = [3, 4, 1, 6, 2]
Input 2:

 A = [1, 5, 2, 5, 6]

Example Output
Output 1:

 15
Output 2:

 11

Example Explanation
Explanation 1:

 Cut the rod of length 5 into 5 rods of length (1, 1, 1, 1, 1) and sell them for (3 + 3 + 3 + 3 + 3) = 15.
Explanation 2:

 Cut the rod of length 5 into 3 rods of length (2, 2, 1) and sell them for (5 + 5 + 1) = 11.
 */

namespace MAANG.AdvancedDSA.DynamicProgramming
{
    public class CuttingRod
    {
        public static int[,] dp;
        public static int solve(List<int> A)
        {
            dp = new int[A.Count + 1, A.Count + 1];

            List<int> lengths = new List<int>();
            for (int i = 0; i < A.Count; i++) {
                lengths.Add(i + 1);
            }

            return maxValues(lengths.Count - 1,
                A.Count,
                A, lengths, A.Count);
        }

        public static int maxValues(int n, int l, List<int> v, List<int> lengths, int c)
        {
            int tprofit = 0;

            if (n < 0) { return 0; }

            if (dp[n, l] != 0) {
                return dp[n, l];
            }

            //Pick the item (can pick the same item as well)
            if ((l - lengths[n]) >= 0) {
                tprofit = v[n] + maxValues(n, l - lengths[n], v, lengths, c);
            }

            //Don't pick the item
            int fprofit = maxValues(n - 1, l, v, lengths, c);

            return dp[n, l] = Math.Max(tprofit, fprofit);
        }
    }
}
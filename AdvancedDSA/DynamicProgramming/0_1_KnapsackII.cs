/*
 * Given two integer arrays A and B of size N each which represent values and weights associated 
 with N items respectively.

Also given an integer C which represents knapsack capacity.

Find out the maximum value subset of A such that sum of the weights of this subset is smaller than or equal to C.

NOTE: You cannot break an item, either pick the complete item, or don’t pick it (0-1 property).

Problem Constraints
1 <= N <= 500

1 <= C, B[i] <= 106

1 <= A[i] <= 50

Input Format
First argument is an integer array A of size N denoting the values on N items.

Second argument is an integer array B of size N denoting the weights on N items.

Third argument is an integer C denoting the knapsack capacity.

Output Format
Return a single integer denoting the maximum value subset of A such that sum of the
weights of this subset is smaller than or equal to C.

Example Input
Input 1:

 A = [6, 10, 12]
 B = [10, 20, 30]
 C = 50
Input 2:

 A = [1, 3, 2, 4]
 B = [12, 13, 15, 19]
 C = 10

Example Output
Output 1:

 22
Output 2:

 0

Example Explanation
Explanation 1:

 Taking items with weight 20 and 30 will give us the maximum value i.e 10 + 12 = 22
Explanation 2:

 Knapsack capacity is 10 but each item has weight greater than 10 so no items can be
considered in the knapsack therefore answer is 0.
*/

namespace MAANG.AdvancedDSA.DynamicProgramming
{
    public class _0_1KnapsackII
    {
        public static int[,] dp;
        public static int solve(List<int> A, List<int> B, int C)
        {           
            dp = new int[A.Count+1, C + 1];

            return findMax(A.Count - 1, C, C, A, B);
        }

        public static int findMax(int index, int rem_wt, int C, List<int> v, List<int> w)
        {
            if(index < 0) {
                return 0;
            }

            if (dp[index,rem_wt] != 0) {
                return dp[index, rem_wt];
            }

            int pickedSum = 0, notPickedSum;

            //Pick the value
            int diff = rem_wt - w[index];
            if(diff >= 0) {
                pickedSum = v[index] + findMax(index - 1, diff, C, v, w);
            }

            //Do not pick that value
            notPickedSum = findMax(index - 1, rem_wt, C, v, w);

            dp[index, rem_wt] = Math.Max(pickedSum, notPickedSum);

            return dp[index, rem_wt];
        }
    }
}
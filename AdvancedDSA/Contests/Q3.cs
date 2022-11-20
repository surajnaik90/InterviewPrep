/*
Given an integer, A. Find and Return first positive A integers in ascending order containing only digits 1, 2, and 3.

NOTE: All the A integers will fit in 32-bit integers.

Problem Constraints
1 <= A <= 29500

Input Format
The only argument given is integer A.

Output Format
Return an integer array denoting the first positive A integers in ascending order containing only digits 1, 2 and 3.

Example Input
Input 1:

 A = 3
Input 2:

 A = 7

Example Output
Output 1:

 [1, 2, 3]
Output 2:

 [1, 2, 3, 11, 12, 13, 21]

Example Explanation
Explanation 1:

 Output denotes the first 3 integers that contains only digits 1, 2 and 3.
Explanation 2:

 Output denotes the first 3 integers that contains only digits 1, 2 and 3.
 */

using System.Text;

public static class Q3
{
    public static int solve(List<int> A, List<int> B, List<int> C)
    {
        A.Sort();

        int N = A.Count, sum = 0;

        int[] newA = new int[N];
        for (int i = N - 1, j = 0; i >= 0; i--, j++) {
            newA[j] = A[i];
        }

        //Calculate prefix sum
        int[] pf = new int[N]; pf[0] = newA[0];
        for (int i = 1; i < N; i++) {
            pf[i] = pf[i - 1] + newA[i];
        }

        int count = B.Count, k = 0;
        for (int i = 0; i < count; i++) {

            int tempSum = B[i] * C[i];

            k += B[i];

            if (k > N) { k -= B[i]; continue; }

            if (k <= 1) { 
                if (pf[k] > tempSum) {
                    sum += tempSum;
                }
                else {
                    sum += pf[k];
                }
            }

            if (k > 1) {
                if (pf[k - 1] > tempSum) {
                    sum += tempSum;
                }
                else {
                    sum += pf[k - 1];
                }
            }
        }

        while (k - 1 < N) {

            sum += newA[k];

            k++;

            if (k >= N) { break; }
        }

        return sum;
    }
}
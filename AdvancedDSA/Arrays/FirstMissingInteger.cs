/*
Given an unsorted integer array, A of size N. Find the first missing positive integer.

Note: Your algorithm should run in O(n) time and use constant space.

Problem Constraints
1 <= N <= 1000000

-109 <= A[i] <= 109

Input Format
First argument is an integer array A.

Output Format
Return an integer denoting the first missing positive integer.

Example Input
Input 1:

[1, 2, 0]
Input 2:

[3, 4, -1, 1]
Input 3:

[-8, -7, -6]

Example Output
Output 1:

3
Output 2:

2
Output 3:

1

Example Explanation
Explanation 1:

A = [1, 2, 0]
First positive integer missing from the array is 3.
 */

public static class FirstMissingInteger
{
    //First missing integer - O(N) Space complexity
    public static int solve(List<int> A)
    {
        int N = A.Count;
        int[] newArray = new int[N+1];

        for (int i = 0; i < N; i++) {

            if (A[i]>N) { continue; }

            if (A[i] >= 0) {
                newArray[A[i]] = -1;
            }
        }

        int j;
        for (j = 1; j< newArray.Length; j++) {

            if (newArray[j] == -1) {
                continue;
            }
            else {
                return j;
            }
        }

        return j;
    }
}
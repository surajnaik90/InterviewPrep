/*
Given an integer array A, sort the array using MyOwnSort.

Problem Constraints

1 <= |A| <= 105

1 <= A[i] <= 109

Input Format

First argument is an integer array A.

Output Format

Return the sorted array.

Example Input

Input 1:

 A = [1, 4, 10, 2, 1, 5]
Input 2:

 A = [3, 7, 1]


Example Output

Output 1:

 [1, 1, 2, 4, 5, 10]
Output 2:

 [1, 3, 7]


Example Explanation

Explanation 1:

 Return the sorted array.
 */

public static class MyOwnSort
{
    public static List<int> solve(List<int> A)
    {
        int N = A.Count;

        for (int i = 0; i < N; i++) {

            for (int j = N - 1; j >= i; j--) {

                if (A[i] >= A[j]) {

                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
        }

        return A;
    }
}
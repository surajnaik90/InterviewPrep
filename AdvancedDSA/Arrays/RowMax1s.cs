/*
Given a binary sorted matrix A of size N x N. Find the row with the maximum number of 1.

NOTE:

If two rows have the maximum number of 1 then return the row which has a lower index.
Rows are numbered from top to bottom and columns are numbered from left to right.
Assume 0-based indexing.
Assume each row to be sorted by values.
Expected time complexity is O(rows).


Problem Constraints

1 <= N <= 1000

0 <= A[i] <= 1

Input Format

The only argument given is the integer matrix A.

Output Format

Return the row with the maximum number of 1.

Example Input

Input 1:

 A = [   [0, 1, 1]
         [0, 0, 1]
         [0, 1, 1]   ]
Input 2:

 A = [   [0, 0, 0, 0]
         [0, 1, 1, 1]    ]


Example Output

Output 1:

 0
Output 2:

 1

Example Explanation

Explanation 1:

 Row 0 has maximum number of 1s.
Explanation 2:

 Row 1 has maximum number of 1s.
 */

public static class RowMax1s
{
    public static int solve(List<List<int>> A)
    {
        int i =0, min_row = i, N = A[0].Count, M = A.Count;

        for (int j = N-1; j >= 0; j--) {

            if (i <= M - 1 && j <= N - 1) {

                if (A[i][j] == 1) {
                    min_row = i; continue;
                }
                else {

                    while (A[i][j] == 0) {
                        i++;
                        if (i > M - 1) {
                            break;
                        }
                    }
                    if (i <= M - 1 && j <= N - 1) {
                        if (A[i][j] == 1) {
                            min_row = i;
                        }
                    }
                }
            }
        }

        return min_row;
    }

    //Simple Coding
    public static int solve2(List<List<int>> A) 
    {
        int row = 0, i, j;

        for (i = 0, j = A[0].Count-1; i <A.Count&&j>0 ; i++) {

            while (A[i][j] == 1 && j >= 0) {
                row = i;
                j--;
            }
        }
        return row;
    }
}
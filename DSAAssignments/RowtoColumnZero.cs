/*
You are given a 2D integer matrix A, make all the elements in a row or column zero if the A[i][j] = 0. Specifically, make entire ith row and jth column zero.



Problem Constraints
1 <= A.size() <= 103

1 <= A[i].size() <= 103

0 <= A[i][j] <= 103



Input Format
First argument is a vector of vector of integers.(2D matrix).



Output Format
Return a vector of vector after doing required operations.



Example Input
Input 1:

[1,2,3,4]
[5,6,7,0]
[9,2,0,4]


Example Output
Output 1:

[1,2,0,0]
[0,0,0,0]
[0,0,0,0]


Example Explanation
Explanation 1:

A[2][4] = A[3][3] = 0, so make 2nd row, 3rd row, 3rd column and 4th column zero.
 */

public static class RowtoColumnZero
{
    public static List<List<int>> Operation1(List<List<int>> A)
    {
        List<List<int>> output = new List<List<int>>();

        int[] rows = new int[A.Count]; int[] columns = new int[A[0].Count];
        for (int r = 0; r < A.Count; r++)
        {
            for (int c = 0; c < A[0].Count; c++)
            {
                if (A[r][c] == 0)
                {
                    rows[r] = 1; columns[c] = 1;
                }
            }
        }

        for (int r = 0; r < A.Count; r++)
        {
            int[] row = new int[A[0].Count];

            if (rows[r]==1) { 
                output.Add(row.ToList()); 
                continue;
            }

            for (int c = 0; c < A[0].Count; c++)
            {
                if (columns[c] == 1) {
                    row[c] = 0;
                }
                else{
                    row[c] = A[r][c];
                }
            }
            output.Add(row.ToList());
        }

        return output;
    }
}
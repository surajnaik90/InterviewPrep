﻿/*
You are given a 2D integer matrix A, return a 1D integer vector containing row-wise sums of original matrix.



Problem Constraints

1 <= A.size() <= 103

1 <= A[i].size() <= 103

1 <= A[i][j] <= 103



Input Format

First argument is a vector of vector of integers.(2D matrix).



Output Format

Return a vector conatining row-wise sums of original matrix.



Example Input

Input 1:

[1,2,3,4]
[5,6,7,8]
[9,2,3,4]


Example Output

Output 1:

{10,26,18}


Example Explanation

Explanation 1

Row 1 = 1+2+3+4 = 10
Row 2 = 5+6+7+8 = 26
Row 3 = 9+2+3+4 = 18
 */

public static class MatrixRowSum
{
    public static List<int> Operation1(List<List<int>> A)
    {
        List<int> output = new List<int>();

        for (int r = 0; r < A.Count; r++)
        {
            int rowSum = 0;
            for (int c = 0; c < A[0].Count; c++)
            {
                rowSum += A[r][c];
            }
            output.Add(rowSum);
        }

        return output;
    }
}
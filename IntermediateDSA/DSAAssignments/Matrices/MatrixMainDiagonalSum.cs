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

public static class MatrixMainDiagonalSum
{
    public static int Operation1(List<List<int>> A)
    {
        int output = 0;

        for (int r = 0; r < A.Count; r++)
        {
            output += A[r][r];
        }

        return output;
    }
}
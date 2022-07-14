/*
You are given a n x n 2D matrix A representing an image.

Rotate the image by 90 degrees (clockwise).

You need to do this in place.

Note: If you end up using an additional array, you will only receive partial score.

Problem Constraints
1 <= n <= 1000

Input Format
First argument is a 2D matrix A of integers

Output Format
Return the 2D rotated matrix.

Example Input
Input 1:

 [
    [1, 2],
    [3, 4]
 ]
Input 2:

 [
    [1]
 ]


Example Output
Output 1:

 [
    [3, 1],
    [4, 2]
 ]
Output 2:

 [
    [1]
 ]


Example Explanation
Explanation 1:

 After rotating the matrix by 90 degree:
 1 goes to 2, 2 goes to 4
 4 goes to 3, 3 goes to 1
Explanation 2:

 2D array remains the ssame as there is only element.
 */

public static class MatrixRotate90
{
    public static void Operation1(List<List<int>> A)
    {
        //First transpose the matrix
        for (int r = 0; r < A[0].Count-1; r++)
        {
            for (int c = r+1; c < A.Count; c++)
            {
                int temp = A[r][c];
                A[r][c] = A[c][r];
                A[c][r] = temp;
            }
        }

        //Reverse the matrix
        for (int c = A[0].Count-1,j=0; c >=0 ; c--,j++)
        {
            if (j == c || j > c) { break; }

            for (int r = 0; r < A.Count; r++)
            {  
                int temp = A[r][j];
                A[r][j] = A[r][c];
                A[r][c] = temp;
            }
        }
    }
}
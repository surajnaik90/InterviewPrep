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

public static class ChristmasTree
{
    public static int Operation1(List<int> A, List<int> B)
    {
        int output = int.MaxValue, k=3, N = A.Count;

        //Find the prefix sum
        List<int> pfSum = new List<int>();
        pfSum.Add(B[0]);
        for (int p = 1; p < B.Count; p++)
        {
            pfSum.Add(pfSum[p - 1] + B[p]);
        }

        int s, e; bool isValidSubarr;
        for (s = 0; s <= N-k; s++)
        {
            e = s + k - 1; isValidSubarr = true;

            for (int j = s+1; j <= e; j++)
            {
                if (A[j] < A[j - 1]) {
                    isValidSubarr = false;
                    break;
                }
            }
            if (isValidSubarr)
            {
                int cost;

                if (s == 0) { cost = pfSum[e]; }

                else { cost = pfSum[e] - pfSum[s - 1]; }

                if (cost < output) { output = cost; }
            }
        }

        if(output == int.MaxValue) { return -1; }

        return output;
    }
}
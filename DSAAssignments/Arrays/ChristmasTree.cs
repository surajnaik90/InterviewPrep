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
    //Brute force approach - Time Limit Exceeds
    public static int Operation1(List<int> A, List<int> B)
    {
        int output = int.MaxValue, N=A.Count;

        for (int i = 0; i < N; i++)
        {
            for (int j = i+1; j < N; j++)
            {
                if (A[j] > A[i])
                {
                    for (int k = j+1; k < N; k++)
                    {
                        if(A[k] > A[j]) {

                            int cost;

                            cost = B[k] + B[j] + B[i];

                            if (cost < output) {
                                output = cost;
                            }

                        }
                    }
                }

            }
        }

        if(output == int.MaxValue) { output = -1; }

        return output;
    }

    //Optimized a bit
    public static int Operation2(List<int> A, List<int> B)
    {
        int output = int.MaxValue, N = A.Count;

        List<List<int>> costs = new List<List<int>>();

        for (int i = 0; i < N; i++)
        {
            List<int> costRow = new List<int>();
            for (int j = i+1; j < N; j++)
            {
                if (A[j] > A[i]){
                    costRow.Add(B[j] + B[i]);
                }
            }
            costs.Add(costRow);
        }

        for (int i = 1; i < costs.Count; i++)
        {
            if (A[i] < A[i + 1])
            {
                for (int j = 0; j < costs[i].Count; j++)
                {
                    int cost;

                    cost = B[i] + costs[i + 1][j];

                    if (cost < output)
                    {
                        output = cost;
                    }
                }
            }
        }

        if (output == int.MaxValue) { output = -1; }

        return output;
    }
}
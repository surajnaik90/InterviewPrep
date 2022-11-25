/*
Given an array of integers A.

A represents a histogram i.e A[i] denotes the height of the ith histogram's bar. Width of each bar is 1.

Find the area of the largest rectangle formed by the histogram.

Problem Constraints
1 <= |A| <= 100000

1 <= A[i] <= 1000000000

Input Format
The only argument given is the integer array A.

Output Format
Return the area of the largest rectangle in the histogram.

Example Input
Input 1:

 A = [2, 1, 5, 6, 2, 3]
Input 2:

 A = [2]

Example Output
Output 1:

 10
Output 2:

 2

Example Explanation
Explanation 1:

The largest rectangle has area = 10 unit. Formed by A[3] to A[4].
Explanation 2:

Largest rectangle has area 2.
 */

using System.Text;

public static class LargestRectangleHistogram
{
    public static int solve(List<int> A)
    {
        int res = 0, N = A.Count;

        int[] left = new int[A.Count];
        int[] right = new int[A.Count];

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < N; i++) {
            stack.Push(A[i]);
        }

        left[0] = -1;
        for (int i = 1; i < N; i++) {

            while(stack.Count!=0 && stack.Peek() >= A[i]) {
                stack.Pop();
            }
            left[i] = stack.Pop();
        }

        return res;
    }
}
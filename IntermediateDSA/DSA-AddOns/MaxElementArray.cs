/* Little Ponny and Maximum Element DR Mra eRe me aig W Flag Question

Problem Description

Little Ponny is given an array, A, of N integers. In a particular operation, he can set any element of the array equal to -1.

He wants your help in finding out the minimum number of operations required such that the maximum element of the resulting
array is B. If it is not possible, then return -1.

Problem Constraints
1<=|A| <= 10
1 <= Ali] <= 10

Input Format

The first argument of input contains an integer array, A.

The second argument of input contains an integer, B.
 */
public static class MaxElementArray
{
    public static int Operation1(List<int> A,int B)
    {
        int count = 0;

        if(!A.Contains(B)) { return -1; }

        for (int i = 0; i < A.Count; i++) {

            if (A[i] > B) { count++; }
        }

        if (count > 0) { return count; }

        return -1;
    }
}
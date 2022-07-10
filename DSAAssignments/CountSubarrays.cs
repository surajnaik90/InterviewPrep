/*
Given an array A of N non-negative numbers and a non-negative number B,
you need to find the number of subarrays in A with a sum less than B.
We may assume that there is no overflow.



Problem Constraints
1 <= N <= 103

1 <= A[i] <= 1000

1 <= B <= 107



Input Format
First argument is an integer array A.

Second argument is an integer B.



Output Format
Return an integer denoting the number of subarrays in A having sum less than B.



Example Input
Input 1:

 A = [2, 5, 6]
 B = 10
Input 2:

 A = [1, 11, 2, 3, 15]
 B = 10


Example Output
Output 1:

 4
Output 2:

 4
 */

public static class CountSubarrays
{
    public static int Operation1(List<int> A, int B)
    {
        int output = 0, sum = B, subarrSum = int.MinValue, N =A.Count;

        for (int s = 0; s < N; s++)
        {
            subarrSum = 0;

            for (int e = s; e < N; e++)
            {
                subarrSum += A[e];

                if(subarrSum < sum)
                {
                    output++;
                }
            }
        }

        return output;
    }
}
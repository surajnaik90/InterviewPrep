/*
Given an array of size N, find the subarray of size K with the least average.



Problem Constraints
1<=k<=N<=1e5
-1e5<=A[i]<=1e5


Input Format
First argument contains an array A of integers of size N.
Second argument contains integer k.


Output Format
Return the index of the first element of the subarray of size k that has least average.
Array indexing starts from 0.


Example Input
Input 1:
A=[3, 7, 90, 20, 10, 50, 40]
B=3
Input 2:

A=[3, 7, 5, 20, -10, 0, 12]
B=2


Example Output
Output 1:
3
Output 2:

4


Example Explanation
Explanation 1:
Subarray between indexes 3 and 5
The subarray {20, 10, 50} has the least average 
among all subarrays of size 3.
Explanation 2:

 Subarray between [4, 5] has minimum average
 */

public static class SubarrayLeastAverage
{

    //Time Limit Exceeded for the below operation as it is a O(N^2) time complexity
    public static int Operation1(List<int> A, int B)
    {
        int output = -1, subarrSum = int.MinValue, N = A.Count;
        double average = double.MaxValue;

        for (int s = 0; s < N; s++)
        {
            subarrSum = 0;

            if ((s + B) <= N)
            {
                for (int e = s, j = 1; e < s + B; e++, j++)
                {
                    subarrSum += A[e];

                    if (j == B)
                    {
                        double res = (double)subarrSum / B;

                        if (res < average)
                        {
                            output = s;
                            average = (double)subarrSum / B;
                        }
                        j = 0; subarrSum = 0;
                    }
                }
            }
            
        }
        return output;
    }


    //Optimized solution - O(N) solution
    public static int Operation2(List<int> A, int B)
    {
        int output = -1, subarrSum = int.MinValue, N = A.Count;
        double average = double.MaxValue;

        int[] prefixSum = new int[N];
        prefixSum[0] = A[0];
        for (int i = 1; i < N; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + A[i];
        }

        int startIndex, endIndex;
        for (int i = 0; i < N; i++)
        {
            if(i+B>N) { continue; }

            startIndex = i; endIndex = i + B-1;

            if (i == 0) { subarrSum = prefixSum[endIndex]; }

            if (i != 0) {
                subarrSum = prefixSum[endIndex] - prefixSum[startIndex - 1];
            }

            double res = (double)subarrSum / B;

            if (res < average)
            {
                output = startIndex;
                average = (double)subarrSum / B;
            }
        }

        return output;
    }
}
/*
Given an array A, find the size of the smallest subarray such that it contains at least one occurrence of the maximum value of the array

and at least one occurrence of the minimum value of the array.



Problem Constraints
1 <= |A| <= 2000



Input Format
First and only argument is vector A



Output Format
Return the length of the smallest subarray which has at least one occurrence of minimum and maximum element of the array



Example Input
Input 1:

A = [1, 3]
Input 2:

A = [2]


Example Output
Output 1:

 2
Output 2:

 1


Example Explanation
Explanation 1:

 Only choice is to take both elements.
Explanation 2:

 Take the whole array.
 */

public static class ClosestMinMax
{

    //Time Limit Exceeded - Not optimized
    public static int Operation1(List<int> A)
    {
        int output = int.MaxValue;

        int min_ind =-1, max_ind =-1, N = A.Count;

        int max = A[0], min = A[0];
        for (int i = 0; i < N; i++)
        {
            if(A[i] > max) { max = A[i]; }

            if (A[i] < min) { min = A[i]; }
        }

        //max...min case
        for (int i = N-1; i >= 0; i--)
        {   
            if (A[i] == min)
            {
                min_ind = i;
            }
            if (A[i] == max)
            {
                if (min_ind != -1)
                {
                    int len = min_ind - i + 1;

                    if(len < output)
                    {
                        output = len;
                    }
                }
            }

        }

        //min...max case
        for (int i = N-1; i >= 0 ; i--)
        {
            if (A[i] == max)
            {
                max_ind = i;
            }
            if (A[i] == min)
            {
                if (max_ind != -1)
                {
                    int len = max_ind - i + 1;

                    if (len < output)
                    {
                        output = len;
                    }
                }
            }
        }

        return output;
    }
}
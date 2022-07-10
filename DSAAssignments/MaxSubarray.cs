/*
Find the contiguous non-empty subarray within an array, A of length N, with the largest sum.



Problem Constraints
1 <= N <= 1e6
-1000 <= A[i] <= 1000



Input Format
The first and the only argument contains an integer array, A.



Output Format
Return an integer representing the maximum possible sum of the contiguous subarray.



Example Input
Input 1:

 A = [1, 2, 3, 4, -10] 
Input 2:

 A = [-2, 1, -3, 4, -1, 2, 1, -5, 4] 


Example Output
Output 1:

 10 
Output 2:

 6 


Example Explanation
Explanation 1:

 The subarray [1, 2, 3, 4] has the maximum possible sum of 10. 
Explanation 2:

 The subarray [4,-1,2,1] has the maximum possible sum of 6. 
 */

public static class MaxSubarray
{
    //Time Limit Exceeds for larger input as this is a O(N^2) time complexity
    public static int Operation1(List<int> A)
    {
        int output = int.MinValue, N= A.Count, sum;
        
        for (int s = 0; s < N; s++)
        {
            sum = 0;
            for (int e = s; e < N; e++)
            {
                sum += A[e];

                if(sum > output)
                {
                    output = sum;
                }
            }
        }
        return output;
    }

    //Find the max element. Traverse on each side to find themax sum of the subarray.
    //THis approach doesn't work. But interesting logic to look into. Please take a look. This code doesnt find the right answer.
    public static int Operation2(List<int> A)
    {
        int output = int.MinValue, N = A.Count, sum=0;

        int max = int.MinValue, maxIndex=-1;
        for (int i = 0; i < N; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
                maxIndex = i;
            }
        }

        //Traverse right of max
        for (int i = maxIndex; i < N ; i++)
        {
            sum += A[i];

            if (sum > output)
            {
                output = sum;
            }
        }

        if(maxIndex==0) { return output; }

        sum = output;
        //Traverse left of max
        for (int i = maxIndex-1; i >= 0; i--)
        {
            sum += A[i];

            if (sum > output)
            {
                output = sum;
            }
        }

        return output;
    }

    //THis doesn't work
    public static int Operation3(List<int> A)
    {
        int output = int.MinValue, N = A.Count, sum = 0, prev = 0;

        for (int i = 0; i < N; i++)
        {
            if (A[i] > output) { output = A[i]; }

            sum += A[i];
            if (sum > output) { output = sum; }

            if(i>1) { 
                int temp = A[i] + A[i - 1];

                if (temp > output) { output = temp; }

                prev = temp + A[i];
            }

            if (prev > output) { output = prev; }
        }

        return output;
    }
}
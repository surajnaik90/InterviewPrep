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

public static class Bulbs
{   
    public static int Operation1(List<int> A)
    {
        int output = 0, N = A.Count; bool isReset = false;

        for (int i = 0; i < N; i++)
        {
            int digit = A[i];

            if(digit==1 && !isReset) { continue; }

            if (i % 2 != 0)
            {
                isReset = true;

                if (A[i] == 0) { digit = 1; }

                else { digit = 0; }
            }

            if(digit == 1) {
                continue;
            }

            else {  output++; isReset = true; }
        }

        return output;
    }
}
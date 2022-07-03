﻿/*
Little Ponny is given an array, A, of N integers. In a particular operation, he can set any element of the array equal to -1.

He wants your help in finding out the minimum number of operations required such that the maximum element of the resulting array is B. If it is not possible, then return -1.



Problem Constraints
1 <= |A| <= 105

1 <= A[i] <= 109



Input Format
The first argument of input contains an integer array, A.

The second argument of input contains an integer, B.



Output Format
Return an integer representing the answer.



Example Input
Input 1:

 A = [2, 4, 3, 1, 5]
 B = 3 
Input 2:

 A = [1, 4, 2]
 B = 3 


Example Output
Output 1:

 2 
Output 2:

 -1 


Example Explanation
Explanation 1:

 We need to remove 4 and 5 to make 3 the biggest element. 
Explanation 2:

 As 3 doesn't exist in the array, the answer is -1. 

 */

public static class LittlePonnyMaxElement
{
    public static int Operation1(List<int> A, int B)
    {
        int output = 0;

        if (!A.Contains(B)) { return -1; }

        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] > B)
            {
                output++;
            }
        }

        return output;
    }
}
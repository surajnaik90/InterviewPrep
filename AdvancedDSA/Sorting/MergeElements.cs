/*
Given two sorted integer arrays A and B, merge B and A as one sorted array and return it as an output.

Problem Constraints
-1010 <= A[i], B[i] <= 1010

Input Format
First Argument is a 1-D array representing A.

Second Argument is also a 1-D array representing B.

Output Format
Return a 1-D vector which you got after merging A and B.

Example Input
Input 1:

A = [4, 7, 9 ]
B = [2, 11, 19 ]
Input 2:

A = [1]
B = [2]

Example Output
Output 1:

[2, 4, 7, 9, 11, 19]
Output 2:

[1, 2]


Example Explanation
Explanation 1:

Merging A and B produces the output as described above.
Explanation 2:

 Merging A and B produces the output as described above.
 */

public static class MergeElements
{
    public static List<int> solve(List<int> A, List<int> B)
    {
        int pointer1 = 0, pointer2 = 0, pointer3=0;
        int m = A.Count, n = B.Count;

        int[] output = new int[m + n];
       
        while(pointer1 < m && pointer2 < n) {

            if (A[pointer1] <= B[pointer2]) {

                output[pointer3] = A[pointer1];
                pointer1++; pointer3++;
            }
            else {

                output[pointer3] = B[pointer2];
                pointer2++; pointer3++;
            }
        }

        while (pointer1 < m) {
            output[pointer3] = A[pointer1];
            pointer1++; pointer3++;
        }

        while (pointer2 < n) {
            output[pointer3] = B[pointer2];
            pointer2++; pointer3++;
        }

        return output.ToList();
    }
}
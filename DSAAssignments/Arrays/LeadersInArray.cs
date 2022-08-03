/*
Given an integer array A containing N distinct integers, you have to find all the leaders in array A.

An element is a leader if it is strictly greater than all the elements to its right side.

NOTE:The rightmost element is always a leader.



Problem Constraints

1 <= N <= 105

1 <= A[i] <= 108



Input Format

First and only argument is an integer array A.



Output Format

Return an integer array denoting all the leader elements of the array.

NOTE: Ordering in the output doesn't matter.



Example Input

Input 1:

 A = [16, 17, 4, 3, 5, 2]
Input 2:

 A = [1, 2]


Example Output

Output 1:

 [17, 2, 5]
Output 2:

 [2]


Example Explanation

Explanation 1:

 Element 17 is strictly greater than all the elements on the right side to it.
 Element 2 is strictly greater than all the elements on the right side to it.
 Element 5 is strictly greater than all the elements on the right side to it.
 So we will return this three elements i.e [17, 2, 5], we can also return [2, 5, 17] or [5, 2, 17] or any other ordering.
Explanation 2:

 Only 2 the rightmost element is the leader in the array.
 */

public static class LeadersInArray
{

    //This is a brute force approach. Not optimized. Time Complexity is  O(N^2)
    public static List<int> Operation1(List<int> A)
    {
        List<int> output = new List<int>();

        int N = A.Count;
        for (int i = 0; i < N; i++)
        {
            if(i+1==N) { output.Add(A[i]); return output; }

            int max = A[i + 1];
            for (int j = i+1; j < N; j++) {

                if (A[j] >= max) { max = A[j]; }
            }

            if (A[i] > max) { output.Add(A[i]); }
        }

        return output;
    }

    //This is a brute force approach. Not optimized. Time Complexity is  O(N^2)
    public static List<int> Operation2(List<int> A)
    {
        List<int> output = new List<int>();
        int N = A.Count;

        //Find the suffix max array
        List<int> suffixMax = new List<int>();

        for (int i = N-1 ; i >=0; i--)
        {
            if(i==N-1) { suffixMax.Add(A[i]); continue; }

            if (A[i] >= suffixMax[i+1]) { suffixMax.Add(A[i]); }

            else { suffixMax.Add(A[i+1]); }
        }

        
        for (int i = 0; i < N; i++)
        {
            if (A[i] == suffixMax[i])
            {
                output.Add(A[i]);
            }
        }

        return output;
    }
}
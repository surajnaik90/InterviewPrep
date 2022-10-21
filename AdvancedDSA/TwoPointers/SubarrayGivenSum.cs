/*
Given an array of positive integers A and an integer B, find and return first continuous subarray which adds to B.

If the answer does not exist return an array with a single element "-1".

First sub-array means the sub-array for which starting index in minimum.

Problem Constraints
1 <= length of the array <= 100000
1 <= A[i] <= 109
1 <= B <= 109

Input Format
The first argument given is the integer array A.

The second argument given is integer B.

Output Format
Return the first continuous sub-array which adds to B and if the answer does not exist return an array with a single element "-1".

Example Input
Input 1:

 A = [1, 2, 3, 4, 5]
 B = 5
Input 2:

 A = [5, 10, 20, 100, 105]
 B = 110


Example Output
Output 1:

 [2, 3]
Output 2:

 -1

Example Explanation
Explanation 1:

 [2, 3] sums up to 5.
Explanation 2:

 No subarray sums up to required number.
 */

public static class SubarrayGivenSumTwoPointers
{
    public static List<int> solve(List<int> A, int B)
    {
        if (A.Count == 0) { return new List<int>() { -1}; }

        int N = A.Count;
        List<int> result = new List<int>();

        int left = 0, right = 0, sum = A[0];

        while(left < N && right < N) {

            if (sum < B) {
                right++;

                if (right < N) {
                    sum += A[right];
                }
            }
            else if(sum > B) {
                sum -= A[left];
                left++;
            }
            else {
                for (int i = left; i <=right; i++) {
                    result.Add(A[i]);
                }
                return result;
            }
        }

        return new List<int>() { -1};
    }
}
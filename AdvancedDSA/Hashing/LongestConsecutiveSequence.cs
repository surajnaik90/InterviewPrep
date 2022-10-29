/*
Given an unsorted integer array A of size N.

Find the length of the longest set of consecutive elements from array A.

Problem Constraints
1 <= N <= 106

-106 <= A[i] <= 106

Input Format
First argument is an integer array A of size N.

Output Format
Return an integer denoting the length of the longest set of consecutive elements from the array A.

Example Input
Input 1:

A = [100, 4, 200, 1, 3, 2]
Input 2:

A = [2, 1]

Example Output
Output 1:

 4
Output 2:

 2

Example Explanation
Explanation 1:

 The set of consecutive elements will be [1, 2, 3, 4].
Explanation 2:

 The set of consecutive elements will be [1, 2].
 */

public static class LongestConsecutiveSequence
{
    public static int solve(List<int> A)
    {
        int length = 0;
        
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < A.Count; i++) {

            if (map.ContainsKey(A[i])) {
                map[A[i]] += 1;
            }
            else {
                map[A[i]] = 1;
            }
        }

        for (int i = 0; i < A.Count; i++) {

            if (map.ContainsKey(A[i] - 1)) {
                continue;
            }
            else {
                int cnt = 0, x = A[i];

                while (map.ContainsKey(x)) {
                    x++; cnt++;
                }

                length =Math.Max(length,cnt);
            }
        }

        return length;
    }
}
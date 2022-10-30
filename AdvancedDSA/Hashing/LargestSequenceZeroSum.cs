/*
Given an array A of N integers.

Find the largest continuous sequence in a array which sums to zero.

Problem Constraints
1 <= N <= 106

-107 <= A[i] <= 107

Input Format
Single argument which is an integer array A.

Output Format
Return an array denoting the longest continuous sequence with total sum of zero.

NOTE : If there are multiple correct answers, return the sequence which occurs first in the array.

Example Input
A = [1,2,-2,4,-4]

Example Output
[2,-2,4,-4]

Example Explanation
[2,-2,4,-4] is the longest sequence with total sum of zero.
*/

using System.IO.MemoryMappedFiles;

public static class LargestSequenceZeroSum
{
    public static List<int> solve(List<int> A)
    {
        int ans = int.MinValue, minIndex = -1;
        List<int> result = new List<int>();
        Dictionary<long, int> map = new Dictionary<long, int>();

        long[] prefixSum = new long[A.Count];
        prefixSum[0] = A[0]; map.Add(0, -1);

        if (map.ContainsKey(prefixSum[0])) {
            map[prefixSum[0]] = 0; ans = 1; minIndex = 0;
        }
        else {
            map.Add(prefixSum[0], 0);
        }

        for (int i = 1; i < A.Count; i++) {

            prefixSum[i] = prefixSum[i - 1] + (long)A[i];

            if (map.ContainsKey(prefixSum[i])) {
                map[prefixSum[i]] = Math.Min(map[prefixSum[i]], i);
                int temp = ans;                
                ans = Math.Max(ans, i - map[prefixSum[i]]);
                if(ans > temp) {
                    minIndex = map[prefixSum[i]] + 1;
                }
            }
            else {
                map.Add(prefixSum[i], i);
            }
        }

        if (ans == int.MinValue) {
            return new List<int>() {};
        }

        int count = ans;
        while(count > 0) {
            result.Add(A[minIndex++]);
            count--;
        }

        return result;
    }
}
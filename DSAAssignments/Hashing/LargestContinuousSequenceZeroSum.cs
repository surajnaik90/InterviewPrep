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
public static class LargestContinuousSequenceZeroSum
{

    //Technique: Maintain a prefix sum. If you find 0 then compute the
    // ask and return
    public static List<int> solve(List<int> A)
    {
        List<int> result = new List<int>();
        Dictionary<long, int> prefixIndexMap = new Dictionary<long, int>();
        long sum = 0; int count = int.MinValue;

        prefixIndexMap.Add(sum, -1);
        for (int i = 0; i < A.Count; i++) {

            sum += A[i];

            if (prefixIndexMap.ContainsKey(sum)) {

                int j = prefixIndexMap[sum] + 1;

                if (i - j + 1 > count) {

                    result.Clear();
                    while (j <= i) {
                        result.Add(A[j++]);
                    }
                    count = i - (prefixIndexMap[sum] + 1) + 1;
                }
            }

            if (prefixIndexMap.ContainsKey(sum)) {
                prefixIndexMap[sum] = Math.Min(prefixIndexMap[sum], i);
            }
            else {
                prefixIndexMap.Add(sum, i);
            }
        }
        return result;
    }
}
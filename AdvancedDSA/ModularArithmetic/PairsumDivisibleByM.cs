/*
Given an array of integers A and an integer B, find and return the number of pairs in A whose sum is divisible by B.

Since the answer may be large, return the answer modulo (109 + 7).

Problem Constraints
1 <= length of the array <= 100000
1 <= A[i] <= 109
1 <= B <= 106

Input Format
The first argument given is the integer array A.
The second argument given is the integer B.

Output Format
Return the total number of pairs for which the sum is divisible by B modulo (109 + 7).

Example Input
Input 1:

 A = [1, 2, 3, 4, 5]
 B = 2
Input 2:

 A = [5, 17, 100, 11]
 B = 28

Example Output
Output 1:

 4
Output 2:

 1

Example Explanation
Explanation 1:

 All pairs which are divisible by 2 are (1,3), (1,5), (2,4), (3,5). 
 So total 4 pairs.
 */

public static class PairsumDivisibleByM
{
    public static int solve(List<int> A, int B)
    {
        int N = A.Count, output = 0, max = int.MinValue;
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < N; i++) {

            max = Math.Max(max, A[i]);

            if (map.ContainsKey(A[i])) {
                map[A[i]]++;
            }
            else {
                map[A[i]] = 1;
            }
        }

        
        for (int i = 0; i < N; i++) {

            map[A[i]]--;

            if (map[A[i]] == 0) {
                map.Remove(A[i]);
            }

            int sum = 0, diff = Math.Abs(A[i] - B);

            while (sum <= max) {

                if (diff == 0) {

                    if (map[A[i]] > 1) {

                        output += map[A[i]];
                    }
                }

                sum = A[i] + diff;

                if (diff == A[i]) {

                    if (map[A[i]] > 1) {
                        output += map[A[i]];
                    }

                    diff += B; continue;
                }

                if (sum % B == 0) {

                    if(map.ContainsKey(diff)) {
                        output += map[diff];
                    }
                }

                diff += B;
            }
        }

        return output;
    }

    public static int solve2(List<int> A, int B)
    {
        long pairs = 0, mod = (long)(Math.Pow(10,9) + 7);
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < A.Count; i++) {

            int reminder = A[i] % B;

            if (map.ContainsKey(reminder)) {
                map[reminder]++;
            }
            else {
                map[reminder] = 1;
            }
        }

        for (int i = 0; i < A.Count; i++) {

            int r;

            double quotient = (double)((double)(A[i] / (double)B));

            int q = (int)(Math.Ceiling(quotient));
            r = Math.Abs(A[i] - (q * B));

            long ans = 0;

            if (map.ContainsKey(A[i]%B)) {
                if (map[A[i] % B] != 0) {
                    map[A[i]%B]--;
                }
            }

            if (map.ContainsKey(r)) {
                ans = map[r];
            }

            pairs += ans;
            pairs %= mod;
        }

        return (int)pairs;
    }
}
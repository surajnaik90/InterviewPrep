/*
You have given an array A having N integers. Let say G is the product of all elements of A.

You have to find the number of distinct prime divisors of G.

Input Format

The first argument given is an Array A, having N integers.
Output Format

Return an Integer, i.e number of distinct prime divisors of G.
Constraints

1 <= N <= 1e5
1 <= A[i] <= 1e5
For Example

Input:
    A = [1, 2, 3, 4]
Output:
     2

Explanation:
    here G = 1 * 2 * 3 * 4 = 24
    and distinct prime divisors of G are [2, 3]
 */

public static class DistinctPrimes
{
    // Sieve's technique
    public static int solve(List<int> A)
    {
        int N = A.Count, max = int.MinValue;
        Dictionary<int, HashSet<int>> distinctPrimes = new Dictionary<int, HashSet<int>>();
        HashSet<int> primes = new HashSet<int>();

        for (int i = 0; i < N; i++) {
            max = Math.Max(max, A[i]);
        }

        int[] count = new int[max + 1];
        for (int i = 2; i*i <= max; i++) {

            for (int j = i*i; j <= max; j += i) {

                if (count[i] == 0) {
                    count[j]++;

                    if (A.Contains(j)) {
                        primes.Add(i);
                    }
                }
            }
        }

        List<int> p = new List<int>();
        for (int i = 0; i < count.Length; i++) {

            if (count[i] == 0) {
                p.Add(i);
            }
        }

        for (int i = 0; i < N; i++) {

            if (A[i]==0 || A[i] == 1) {
                continue;
            }

            if (count[A[i]] == 0) {
                primes.Add(A[i]);
            }
        }

        return primes.Count;
    }
}
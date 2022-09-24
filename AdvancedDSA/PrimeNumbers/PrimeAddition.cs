/*
You are given an even number N and you need to represent the given number as the sum of primes.
The prime numbers do not necessarily have to be distinct. It is guaranteed that at least one possible solution exists.

You need to determine the minimum number of prime numbers needed to represent the given number.

Input

The first argument contains an integer N,the number you need to represent (2<=N<=10^9).
Output

Return an integer which is the minimum number of prime numbers needed to represent the given number N.
Examples

Input

26
Output

2
Explanation

Testcase 1-

You can represent 26 as: 13+13
So we require minimum of 2 prime numbers to represent the number 26.
 */

public static class PrimeAddition
{
    // Sieve's technique
    public static int solve(int A)
    {
        List<int> output = new List<int>();
        bool[] primes = new bool[A + 1];
        primes = Enumerable.Repeat(true, A + 1).ToArray();

        for (int i = 2; i*i <= A; i++) {

            for (int j = i * i; j <= A; j += i) {
                primes[j] = false;
            }
        }
        
        primes[0] = false;
        primes[1] = false;

        for (int i = primes.Length-1; i >= 0; i--) {

            if (primes[i] == true) {

                int diff = Math.Abs(i - A);

                if (diff == 0) {
                    return 1;
                }

                if (primes[diff]==true) {
                    return 2;
                }

            }
        }

        return 1;
    }
}
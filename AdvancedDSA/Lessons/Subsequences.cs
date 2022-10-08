/*
Given an integer array A, generate all subsequences

This is a cool technique to find all subsequences of a given array.

For any given array of size N, there will be 2^N subsequences which includes the empty subsequence.

So, we can have binary representation of 2^N and use bit manipulation to generate all subsequences.
 */

using System.Linq;

public static class Subsequences
{
    public static List<List<int>> solve(List<int> A)
    {
        List<List<int>> subsequences = new List<List<int>>();
        int N = A.Count, range = (int)Math.Pow(2, N);

        for (int i = 0; i < range; i++) {

            List<int> sequence = new List<int>();
            for (int j = 0; j < N; j++) {

                if( ((1<<j)&i) != 0) {
                    sequence.Add(A[j]);
                }
            }
            subsequences.Add(sequence);
        }

        return subsequences;
    }
}
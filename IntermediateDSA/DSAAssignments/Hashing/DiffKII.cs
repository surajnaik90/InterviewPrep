/*
Given an array A of integers and another non negative integer k, 
find if there exists 2 indices i and j such that A[i] - A[j] = k, i != j.

Example :

Input :

A : [1 5 3]
k : 2
Output :

1
as 3 - 1 = 2

Return 0 / 1 for this problem. 
 */
public static class DiffKII
{
    public static int solve(List<int> A, int B)
    {
        HashSet<int> keys = new HashSet<int>();

        for (int i = 0; i < A.Count; i++) {

            if (keys.Contains(A[i] + B) || keys.Contains(A[i]-B)) {
                return 1;
            }

            keys.Add(A[i]);
        }

        return 0;
    }
}
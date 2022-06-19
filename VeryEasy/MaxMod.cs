/*
Given an array A of size N, Groot wants you to pick 2 indices i and j such that

1 <= i, j <= N
A[i] % A[j] is maximum among all possible pairs of (i, j).
Help Groot in finding the maximum value of A[i] % A[j] for some i, j.

Problem Constraints
1 <= N <= 100000
0 <= A[i] <= 100000
*/
public static class MaxMod
{
    public static int Operation1(List<int> A)
    {
        int maxValue = 0 , N = A.Count(), i, j;
        List<int> modValues = new List<int>();

        if(N==1) { return A[0]; }

        for(i = 0; i< N; i++) {

            j = i + 1;
            try
            {
                if ((A[i] % A[j]) > maxValue) {
                    maxValue = A[i]%A[j];
                }
                else if ((A[j] % A[i]) > maxValue) {
                    maxValue = A[j] % A[i];
                }
                else { }
            }
            catch (Exception) { }
        }
        return maxValue;
    }
}
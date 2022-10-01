/*
Sort the elements using Bubble Sort algorithm.
 */

public static class BubbleSort
{
    public static void solve(List<int> A)
    {
        int N = A.Count;

        for (int i = 0; i < N - 1; i++) {

            for (int j = i + 1; j < N; j++) {

                if (A[i] > A[j]) {
                    int temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
        }
    }
}
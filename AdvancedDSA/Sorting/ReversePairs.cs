/*
Given an array of integers A, we call (i, j) an important reverse pair if i < j and A[i] > 2*A[j].
Return the number of important reverse pairs in the given array A.

Problem Constraints
1 <= length of the array <= 105

-2 * 109 <= A[i] <= 2 * 109

Input Format
The only argument given is the integer array A.

Output Format
Return the number of important reverse pairs in the given array A.

Example Input
Input 1:

 A = [1, 3, 2, 3, 1]
Input 2:

 A = [4, 1, 2]

Example Output
Output 1:

 2
Output 2:

 1

Example Explanation
Explanation 1:

 There are two pairs which are important reverse i.e (3, 1) and (3, 1).
Explanation 2:

 There is only one pair i.e (4, 1).
 */

public static class ReversePairs
{
    public static int solve(List<int> A)
    {
        int reversePairs;

        int l = 0, r = A.Count - 1;

        List<int> list =  MergeSort(A,l,r, out reversePairs);

        return reversePairs;
    }

    private static List<int> MergeSort(List<int> array, int left, int right, out int ans) 
    {
        if (left == right) {
            ans = 0;
            return new List<int> () { array [left] };
        }

        ans = 0;  int res; int l = left, r = right;

        List<int> mergedArray;
        int mid = (left + right) / 2;

        List<int> half1 = MergeSort(array, l, mid, out res);
        ans += res;

        List<int> half2 = MergeSort(array, mid+1, r, out res);
        ans += res;

        mergedArray = Merge(half1 , half2,  out res);
        ans += res;

        return mergedArray;
    }

    private static List<int> Merge(List<int> half1, List<int> half2, out int ans)
    {
        List<int> res = new List<int>();

        int m = half1.Count, n = half2.Count;
        int p1 = 0, p2 = 0; ans = 0;

        while ((p1 < m) && (p2 < n)) {

            if(half1[p1] <= half2[p2]) {
                res.Add(half1[p1]);
                p1++;
            }
            else {
                if (half1[p1] > (2 * half2[p2])) {
                    ans++;
                }
                res.Add(half2[p2]);
                p2++;
            }
        }

        while (p1 < m) {
            if (p1 < m - 1) {
                if (half1[p1] > (2 * half1[p1 + 1])) {
                    ans++;
                }
            }
            res.Add(half1[p1]);
            p1++;
        }

        while(p2 < n) {
            if (p2 < n - 1) {
                if (half2[p2] > (2 * half2[p2 + 1])) {
                    ans++;
                }
            }
            res.Add(half2[p2]);
            p2++;
        }

        return res;
    }
}
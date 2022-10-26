/*
Given an array A of N integers, are there elements a, b, c in S such that a + b + c = 0

Find all unique triplets in the array which gives the sum of zero.

Note:

Elements in a triplet (a,b,c) must be in non-descending order. 
(ie, a ≤ b ≤ c) The solution set must not contain duplicate triplets.

Problem Constraints

0 <= N <= 7000

-108 <= A[i] <= 108

Input Format

Single argument representing a 1-D array A.

Output Format

Output a 2-D vector where each row represent a unique triplet.

Example Input

A = [-1,0,1,2,-1,4]

Example Output

[ [-1,0,1],
  [-1,-1,2] ]

Example Explanation

Out of all the possible triplets having total sum zero,only the above two triplets are unique.
 */

public static class ThreeSumZero
{
    //Handling duplicates is bit challenging
    public static List<List<int>> solve(List<int> A)
    {
        A.Sort();

        List<List<int>> triplets = new List<List<int>>();

        int N = A.Count, left, right, a;
        long sum = 0;

        for (int i = 0; i < N; i++) {

            if (i!=0 && A[i] == A[i - 1]) {
                continue;
            }
            a = A[i];
            List<int> triplet = null;
            left = i + 1; right = N - 1;

            while (left <= right) {

                sum = (long)(a + A[left] + A[right]);

                if (sum > 0) {
                    right--;
                }
                else if (sum == 0) {
                    triplet = new List<int>();

                    triplet.Add(a);
                    triplet.Add(A[left]);
                    triplet.Add(A[right]);                    
                    triplets.Add(triplet);

                    left++; right--;
                }
                else {
                    left++;
                }
            }
        }

        return triplets;
    }
}
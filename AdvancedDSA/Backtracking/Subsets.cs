/*
Given a set of distinct integers A, return all possible subsets.

NOTE:

Elements in a subset must be in non-descending order.
The solution set must not contain duplicate subsets.
Also, the subsets should be sorted in ascending ( lexicographic ) order.
The list is not necessarily sorted.

Problem Constraints
1 <= |A| <= 16
INTMIN <= A[i] <= INTMAX

Input Format
First and only argument of input contains a single integer array A.

Output Format
Return a vector of vectors denoting the answer.

Example Input
Input 1:

A = [1]
Input 2:

A = [1, 2, 3]

Example Output
Output 1:
[
    []
    [1]
]
Output 2:

[
 []
 [1]
 [1, 2]
 [1, 2, 3]
 [1, 3]
 [2]
 [2, 3]
 [3]
]
Example Explanation
Explanation 1:

 You can see that these are all possible subsets.
Explanation 2:

You can see that these are all possible subsets.
 */

using System.Collections;


public static class Subsets
{
    public static List<List<int>> subsets;

    static Subsets()
    {
        subsets = new List<List<int>>();
    }
    public static List<List<int>> solve(List<int> A)
    {
        List<List<int>> ans = new List<List<int>>();

        subsets.Add(new List<int>());

        PrintSubsets(0, new List<int>(), A);

        return ans;
    }

    public static void PrintSubsets(int index, List<int> temp, List<int> A)
    {
        if(index == A.Count) {
            return;
        }

        for (int i = index; i < A.Count; i++) {

            temp.Add(A[i]);

            List<int> list = new List<int>();
            for (int j = 0; j < temp.Count; j++) {
                list.Add(temp[j]);
            }
            subsets.Add(list);

            PrintSubsets(index+1, temp, A);
                        
            temp.Remove(A[i]);

            PrintSubsets(index, temp, A);
        }

        return;
    }
}
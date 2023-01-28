﻿/*
Given an integer array A of size N denoting collection of numbers, 
return all possible permutations.

NOTE:

No two entries in the permutation sequence should be the same.
For the purpose of this problem, assume that all the numbers in the collection are unique.
Return the answer in any order
WARNING: DO NOT USE LIBRARY FUNCTION FOR GENERATING PERMUTATIONS. 
Example : next_permutations in C++ / itertools.permutations in python.
If you do, we will disqualify your submission retroactively and give you penalty points.

Problem Constraints
1 <= N <= 9

Input Format
Only argument is an integer array A of size N.

Output Format
Return a 2-D array denoting all possible permutation of the array.

Example Input
A = [1, 2, 3]

Example Output
[ [1, 2, 3]
  [1, 3, 2]
  [2, 1, 3] 
  [2, 3, 1] 
  [3, 1, 2] 
  [3, 2, 1] ]

Example Explanation
All the possible permutation of array [1, 2, 3].
 */

using System.Collections;
using System.Net.Http.Headers;

public static class Permutations
{
    static List<List<int>> result = new List<List<int>>();
    public static List<List<int>> solve(List<int> A)
    {
        HashSet<int> values = new HashSet<int>();

        for (int i = 0; i < A.Count; i++) {
            values.Add(A[i]);
        }

        computePermutations(values, new List<int>());

        return result;
    }

    public static void computePermutations(HashSet<int> set,
        List<int> list)
    {

        List<int> localList = new List<int>();
        for (int i = 0; i < list.Count; i++) {
            localList.Add(list[i]);
        }

        if (set.Count == 0) {
            result.Add(list);
            return;
        }

        HashSet<int> numbers = new HashSet<int>();
        for (int i = 0; i < set.Count; i++) {
            numbers.Add(set.ElementAt(i));
        }

        for (int i = 0; i < set.Count; i++) {

            int element = set.ElementAt(i);

            localList.Add(element);

            numbers.Remove(element);

            computePermutations(numbers, localList);
        }
    }
}
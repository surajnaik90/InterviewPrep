/*
Given two arrays of integers A and B, Sort A in such a way that the relative order 
among the elements will be the same as those are in B.
For the elements not present in B, append them at last in sorted order.

Return the array A after sorting from the above method.

NOTE: Elements of B are unique.

Problem Constraints
1 <= length of the array A <= 100000

1 <= length of the array B <= 100000

-10^9 <= A[i] <= 10^9

Input Format
The first argument given is the integer array A.

The second argument given is the integer array B.

Output Format
Return the array A after sorting as described.

Example Input
Input 1:

A = [1, 2, 3, 4, 5]
B = [5, 4, 2]
Input 2:

A = [5, 17, 100, 11]
B = [1, 100]


Example Output
Output 1:

[5, 4, 2, 1, 3]
Output 2:

[100, 5, 11, 17]

Example Explanation
Explanation 1:

 Simply sort as described.
Explanation 2:

 Simply sort as described.
*/
public static class SortArrayGivenOrder
{
    public static List<int> solve(List<int> A, List<int> B)
    {
        int N = A.Count; A.Sort();
        List<int> result = new List<int>();
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < A.Count; i++) {

            if (map.ContainsKey(A[i])) {
                map[A[i]]++;
            }
            else {
                map.Add(A[i], 1);
            }
        }

        

        for (int i = 0; i < B.Count; i++) {

            if (map.ContainsKey(B[i])) {

                while (map[B[i]] > 0) {
                    result.Add(B[i]);
                    map[B[i]]--;
                }

                if (map[B[i]] == 0) {
                    map.Remove(B[i]);
                }
            }
        }

        for (int i = 0; i < map.Count; i++) {

            while (map.ElementAt(i).Value > 0) {
                result.Add(map.ElementAt(i).Key);
                map[map.ElementAt(i).Key] -= 1;
            }
        }

        return result;
    }
}
/* Given an array B of length A with elements 1 or 0. Find the number of subarrays with bitwise OR 1.


Problem Constraints
1 <= A <= 105


Input Format
The first argument is a single integer A.
The second argument is an integer array B.


Output Format
Return the number of subarrays with bitwise array 1.


Example Input
Input 1:
 A = 3
B = [1, 0, 1]
Input 2:
 A = 2
B = [1, 0]


Example Output
Output 1:
5
Output2:
2


Example Explanation
Explanation 1:
The subarrays are :- [1], [0], [1], [1, 0], [0, 1], [1, 0, 1]
Except the subarray [0] all the other subarrays has a Bitwise OR = 1
Explanation 2:
The subarrays are :- [1], [0], [1, 0]
Except the subarray [0] all the other subarrays has a Bitwise OR = 1 */
public static class SubarrayswithBitwiseOR1
{

    //Time Limit Exceeds. TC: O(N^2)
    public static long Operation1(int A, List<int> B)
    {
        long output=0;

        for (int s = 0; s < A; s++)
        {
            int res = B[s];

            for (int e = s; e < A; e++) {

                res |= B[e];

                if (res == 1) { output++; }
            }
        }

        return output;
    }

    //Optimized version : O(N)
    public static long Operation2(int A, List<int> B)
    {
        long N = A, output = 0;

        long count = 0; int i;
        for (i = 0; i < A ; i++)
        {
            output += N--;

            if (B[i] == 0) { count++; }

            else if (B[i] == 1) {
                output -= ((count * (count + 1)) / 2);
                count = 0;
            }
            else { }
        }

        if (i==A && B[i-1]==0) { output -= ((count * (count + 1)) / 2); }

        return output;
    }
}
/*
Given 2 integers A and B and an array of integers C of size N. Element C[i] represents the length of ith board.
You have to paint all N boards [C0, C1, C2, C3 … CN-1]. There are A painters available and each of them takes
B units of time to paint 1 unit of the board.

Calculate and return the minimum time required to paint all boards under the constraints that any painter will
only paint contiguous sections of the board.
NOTE:
1. 2 painters cannot share a board to paint. That is to say, a board cannot be painted partially by one painter, 
and partially by another.2. A painter will only paint contiguous boards. This means a configuration where painter
1 paints boards 1 and 3 but not 2 is invalid.

Return the ans % 10000003.

Problem Constraints
1 <= A <= 1000
1 <= B <= 106
1 <= N <= 105
1 <= C[i] <= 106

Input Format
The first argument given is the integer A.
The second argument given is the integer B.
The third argument given is the integer array C.

Output Format
Return minimum time required to paint all boards under the constraints that any painter will only paint
contiguous sections of board % 10000003.

Example Input
Input 1:

 A = 2
 B = 5
 C = [1, 10]
Input 2:

 A = 10
 B = 1
 C = [1, 8, 11, 3]

Example Output
Output 1:

 50
Output 2:

 11

Example Explanation
Explanation 1:

 Possibility 1:- One painter paints both blocks, time taken = 55 units.
 Possibility 2:- Painter 1 paints block 1, painter 2 paints block 2, time take = max(5, 50) = 50
 There are no other distinct ways to paint boards.
 ans = 50 % 10000003
Explanation 2:

 Each block is painted by a painter so, Painter 1 paints block 1, painter 2 paints block 2, painter 3 paints block 3 
 and painter 4 paints block 4, time taken = max(1, 8, 11, 3) = 11
 ans = 11 % 10000003

 */

public static class PainterPartition
{
    public static int solve(int A, int B, List<int> C)
    {
        long b = B;
        long sum = 0; bool isValid;
        long maxMinTime; int output = int.MaxValue;

        //Calculate search space
        for (int i = 0; i < C.Count; i++) {
            sum += b * ((long)C[i]);
        }

        long l = 1, r = sum, mid;

        while (l <= r) {

            mid = (l + r) / 2;

            maxMinTime = 0;
            isValid = isValidAssignment(C, mid, out maxMinTime, A, B);

            output = Math.Min(output, (int)maxMinTime);

            if (isValid) {
                //l = mid + 1;
                r = mid - 1;
            }
            else {
                //r = mid - 1;
                l = mid + 1;
            }
        }

        return output;
    }

    private static bool isValidAssignment(List<int> C, long mid, out long minTime, int painters, int hours)
    {
        minTime = 0; List<long> result = new List<long>();
        long sum = 0; long b = hours;

        for (int i = 0; i < C.Count; i++) {

            if ((sum + (b * ((long)C[i]))) <= mid) {
                sum += b * ((long)C[i]);
            }
            else {
                painters--;
                minTime = Math.Max(minTime, sum);
                result.Add(sum);
                sum = b * ((long)C[i]);
            }
            if (painters == 0) {
                minTime = Math.Max(minTime, sum);
                return true;
            }
        }

        if (sum > mid) {
            painters--;
        }

        minTime = Math.Max(minTime, sum);

        if (painters >=0) {
            return true;
        }

        return false;
    }
}
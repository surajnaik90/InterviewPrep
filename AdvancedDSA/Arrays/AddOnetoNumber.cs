/*
Given a non-negative number represented as an array of digits, add 1 to the number ( increment the number represented by the digits ).

The digits are stored such that the most significant digit is at the head of the list.

NOTE: Certain things are intentionally left unclear in this question which you should practice asking the interviewer. 
For example: for this problem, the following are some good questions to ask :

Q: Can the input have 0's before the most significant digit. Or, in other words, is 0 1 2 3 a valid input?
A: For the purpose of this question, YES
Q: Can the output have 0's before the most significant digit? Or, in other words, is 0 1 2 4 a valid output?
A: For the purpose of this question, NO. Even if the input has zeroes before the most significant digit.

Problem Constraints
1 <= size of the array <= 1000000

Input Format
First argument is an array of digits.

Output Format
Return the array of digits after adding one.

Example Input
Input 1:

[1, 2, 3]

Example Output
Output 1:

[1, 2, 4]

Example Explanation
Explanation 1:

Given vector is [1, 2, 3].
The returned vector should be [1, 2, 4] as 123 + 1 = 124.

 */

public static class AddOneToNumber
{
    public static List<int> solve(List<int> A)
    {
        int N = A.Count, i; bool lastSeenBefore = false;

        for (i = 0; i < N; i++) {

            if (A[i]==0 && !lastSeenBefore) {
                continue;
            }
            else {
                break;
            }
        }

        int length = N - i; int[] output = new int[length + 1];
        int k = output.Length-1;
        
        int rem = (A[N - 1] + 1) % 10; 
        output[k] = rem; k--;

        int cf = (A[N - 1] + 1) / 10;

        for (int j = N-2; j >=i; j--,k--) {

            rem = (A[j] + cf) % 10;

            cf = (A[j] + cf) / 10;

            output[k] = rem;
        }

        if (k == 0) {
            output[k] = cf;
        }

        if (output[0]==0) {
            List<int> res = output.ToList();
            res.RemoveAt(0);
            return res;
        }
        
        return output.ToList();
    }
}
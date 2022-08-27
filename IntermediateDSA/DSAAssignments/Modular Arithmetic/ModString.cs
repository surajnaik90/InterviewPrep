/*
ts
1 <= A.length() <= 105
0 <= Ai <= 9
1 <= B <= 109

Input Format
The first argument is a string A.
The second argument is an integer B.

Output Format
Return a single integer denoting the value of A % B.

Example Input
Input 1:
A = "143"
B = 2
Input 2:

A = "43535321"
B = 47


Example Output
Output 1:
1
Output 2:

20

Example Explanation
Explanation 1:
143 is an odd number so 143 % 2 = 1.
Explanation 2:

43535321 % 47 = 20
 */

using System.Text;

public static class ModString
{
    //Technique: Think of a smaller problem and approach it.
    public static int Operation1(string A, int B)
    {
        int reminder = 0;

        for (int i = 0; i < A.Length; i++) {

            StringBuilder strNumBuilder = new StringBuilder();

            strNumBuilder.Append(reminder);
            strNumBuilder.Append(A[i]);

            string strNum = strNumBuilder.ToString();

            long num = Convert.ToInt64(strNum);

            reminder = (int) (num % Convert.ToInt64(B)); 
        }

        return reminder;
    }
}
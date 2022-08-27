/*
Given a number A, we need to find the sum of its digits using recursion.

Problem Constraints
1 <= A <= 109

Input Format
The first and only argument is an integer A.

Output Format
Return an integer denoting the sum of digits of the number A.

Example Input
Input 1:

 A = 46
Input 2:

 A = 11

Example Output
Output 1:

 10
Output 2:

 2

Example Explanation
Explanation 1:

 Sum of digits of 46 = 4 + 6 = 10
Explanation 2:

 Sum of digits of 11 = 1 + 1 = 2
 */
public static class MagicNumber1
{
    public static int operate(int A)
    {
        int value = find(A);

        if(value == 1) { 
            return 1;
        }
        else{
            return 0;
        }
    }
    private static int find(int n)
    {
        string number = n.ToString();

        if (number.Length == 1) { 
            return Convert.ToInt32(number);
        }

        int res = find(n / 10) + (n % 10);

        return find(res);
    }
}
/*
An arithmetic expression is given by a string array A of size N. 
Evaluate the value of an arithmetic expression in Reverse Polish Notation.

Valid operators are +, -, *, /. Each string may be an integer or an operator.

Problem Constraints
1 <= N <= 105

Input Format
The only argument given is string array A.

Output Format
Return the value of arithmetic expression formed using reverse Polish Notation.

Example Input
Input 1:
    A =   ["2", "1", "+", "3", "*"]
Input 2:
    A = ["4", "13", "5", "/", "+"]

Example Output
Output 1:
    9
Output 2:
    6

Example Explanation
Explaination 1:
    starting from backside:
    * : () * ()
    3 : () * (3)
    + : (() + ()) * (3)
    1 : (() + (1)) * (3)
    2 : ((2) + (1)) * (3)
    ((2) + (1)) * (3) = 9
Explaination 2:
    + : () + ()
    / : () + (() / ())
    5 : () + (() / (5))
    13 : () + ((13) / (5))
    4 : (4) + ((13) / (5))
    (4) + ((13) / (5)) = 6
 */

using System.Text;

public static class EvaluateExpression
{
    public static int solve(List<string> A)
    {
        int N = A.Count, op1, op2, res;

        Stack<string> chars = new Stack<string>();

        for (int i = 0; i < N; i++) {

            if (A[i] == "+") {
                op2 = Convert.ToInt32(chars.Pop());
                op1 = Convert.ToInt32(chars.Pop());

                res = op1 + op2;

                chars.Push(res.ToString());
            }
            else if (A[i] == "-") {
                op2 = Convert.ToInt32(chars.Pop());
                op1 = Convert.ToInt32(chars.Pop());

                res = op1 - op2;

                chars.Push(res.ToString());
            }
            else if (A[i] == "*") {
                op2 = Convert.ToInt32(chars.Pop());
                op1 = Convert.ToInt32(chars.Pop());

                res = op1 * op2;

                chars.Push(res.ToString());
            }
            else if (A[i] == "/") {
                op2 = Convert.ToInt32(chars.Pop());
                op1 = Convert.ToInt32(chars.Pop());

                res = op1 / op2;

                chars.Push(res.ToString());
            }
            else {
                chars.Push(A[i]);
            }
        }

        res = Convert.ToInt32(chars.Pop());

        return res;
    }
}
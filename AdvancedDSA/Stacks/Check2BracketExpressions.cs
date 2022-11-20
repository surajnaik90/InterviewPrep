/*
Given two strings A and B. Each string represents an expression consisting of 
lowercase English alphabets, '+', '-', '(' and ')'.

The task is to compare them and check if they are similar. 
If they are identical, return 1 else, return 0.

NOTE: It may be assumed that there are at most 26 operands from ‘a’ to ‘z’,
and every operand appears only once.

Problem Constraints
1 <= length of the each String <= 100

Input Format
The given arguments are string A and string B.

Output Format
Return 1 if they represent the same expression else return 0.

Example Input
Input 1:

 A = "-(a+b+c)"
 B = "-a-b-c"
Input 2:

 A = "a-b-(c-d)"
 B = "a-b-c-d"

Example Output
Output 1:

 1
Output 2:

 0

Example Explanation
Explanation 1:

The expression "-(a+b+c)" can be written as "-a-b-c" which is equal as B. 
Explanation 2:

 Both the expression are different.
 */

public static class Check2BracketExpressions
{
    public static int solve(string A, string B)
    {
        Stack<char> stackA = CreateStack(A);
        Stack<char> stackB = CreateStack(B);

        while(stackA.Count > 0) {

            char a = stackA.Pop();
            char b = stackB.Pop();

            if (a != b) {
                return 0;
            }
        }

        return 1;
    }

    public static Stack<char> CreateStack(string str)
    {
        Stack<char> stackA = new Stack<char>();
        char currSymbol;

        for (int i = 0; i < str.Length; i++) {

            if (str[i] == '(') {

                if (i == 0) {
                    currSymbol = '+';
                }
                else {
                    currSymbol = str[i - 1];
                }
                
                i += 1;

                while (str[i] != ')' && i < str.Length) {

                    if (str[i] == '+' || str[i] == '-') {
                        if (str[i] == currSymbol) {
                            stackA.Push('+');
                        }
                        else if (str[i] != currSymbol) {
                            stackA.Push('-');
                        }
                    }
                    else {
                        stackA.Push(str[i]);
                    }
                    i++;
                }
            }
            else {
                stackA.Push(str[i]);
            }
        }

        return stackA;
    }
}
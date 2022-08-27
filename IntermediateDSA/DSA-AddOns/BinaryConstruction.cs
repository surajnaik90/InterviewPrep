/* Problem Description

Construct a binary number having A 1's followed by B O's. Return the decimal value of that binary number.

For eg -
A=3,B=2
Answer = (11100), . Return = 28

Problem Constraints

1<=A+B<=30

Input Format

The first argument is a single integer A.
The second argument is a single integer B.
 */
public static class BinaryConstruction
{
    public static int Operation1(int A, int B)
    {
        int output = 0;

        int count = B - 1 + A;
        for (int i = 0; i < A; i++) {

            output += Convert.ToInt32(Math.Pow(2, count));

            count--;
        }

        return output;
    }
}
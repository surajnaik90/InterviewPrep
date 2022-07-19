/* Write a function that takes an integer and returns the number of 1 bits it has.


Problem Constraints
1 <= A <= 109


Input Format
First and only argument contains integer A


Output Format
Return an integer as the answer


Example Input
Input1:
11


Example Output
Output1:
3


Example Explanation
Explaination1:
11 is represented as 1011 in binary. */
public static class BitNumberof1bits
{
    public static int Operation1(int A)
    {
        int output = 0;

        while (A >= 1)
        {
            if ((A & 1) == 1)
            {
                output++;
            }

            A = A / 2;
        }

        return output;
    }
}
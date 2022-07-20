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
public static class BitReverseBits
{
    public static long Operation1(long A)
    {
        long output, N=A; int count = 0;

        while (N >= 1) {

            count++;

            N = N / 2;
        }

        
        output = A << (32-count);

        int onescount = 0; long M=A;

        while (M >= 1)
        {
            if ((M & 1) == 1)
            {
                onescount++;
            }

            M = M / 2;
        }

        if (onescount==1) { output /= A; }

        return output;
    }
}
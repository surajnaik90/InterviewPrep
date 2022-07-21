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
        long output=0, N=A; int j = 31;

        while (N != 0) {

            int item = (N & 1) == 1 ? 1 : 0;
            
            output += item * (Convert.ToInt64(Math.Pow(2, j--)));

            N = N / 2;
        }

        return output;
    }
}
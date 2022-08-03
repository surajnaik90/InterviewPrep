/* Reverse the bits of an 32 bit unsigned integer A.



Problem Constraints
0 <= A <= 232



Input Format
First and only argument of input contains an integer A.



Output Format
Return a single unsigned integer denoting the decimal value of reversed bits.



Example Input
Input 1:

 0
Input 2:

 3


Example Output
Output 1:

 0
Output 2:

 3221225472


Example Explanation
Explanation 1:

        00000000000000000000000000000000    
=>      00000000000000000000000000000000
Explanation 2:

        00000000000000000000000000000011    
=>      11000000000000000000000000000000 */
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
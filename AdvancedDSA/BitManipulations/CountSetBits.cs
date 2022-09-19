/*
Given a positive integer A, the task is to count the total number of set bits in the binary representation of all the numbers from 1 to A.

Return the count modulo 109 + 7.

Problem Constraints

1 <= A <= 109


Input Format

First and only argument is an integer A.


Output Format

Return an integer denoting the ( Total number of set bits in the binary representation of all the numbers from 1 to A )modulo 109 + 7.


Example Input

Input 1:

 A = 3
Input 2:

 A = 1


Example Output

Output 1:

 4
Output 2:

 1


Example Explanation

Explanation 1:

 DECIMAL    BINARY  SET BIT COUNT
    1          01        1
    2          10        1
    3          11        2
 1 + 1 + 2 = 4 
 Answer = 4 % 1000000007 = 4
Explanation 2:

 A = 1
  DECIMAL    BINARY  SET BIT COUNT
    1          01        1
 Answer = 1 % 1000000007 = 1
 */

public static class CountSetBits
{
    //Time Limit Exceeds
    public static int solve(int A)
    {
        int output = 0, i = 0;
        
        while (i <= 31) {

            for (int j = 1; j <= A; j++) {

                if ( (j&(1<<i)) != 0) {
                    output++;
                }
            }
            i++;

            output = output % (int)((Math.Pow(10, 9)) + 7);
        }

        return output;
    }


    public static int solve2(int A)
    {
        int output = 0, val = (int)((Math.Pow(10, 9)) + 7);

        int N = A + 1;
        int mod = (int)(Math.Max(10, 9) + 7);

        int setSize = 2;

        int ans = 0;
        while(setSize/2 <= N) {

            ans += (N / setSize) * (setSize / 2);
            ans %= mod;

            ans += (N%setSize <=  (setSize/2)) ? 0 :  N%setSize - (setSize/2);

            ans %= mod;

            setSize += 2;
        }

        return output;
    }
}
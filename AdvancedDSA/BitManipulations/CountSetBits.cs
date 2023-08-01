/*
Given a positive integer A, the task is to count the total number of set bits in the binary
representation of all the numbers from 1 to A.

Return the count modulo 109 + 7.

Problem Constraints

1 <= A <= 109


Input Format

First and only argument is an integer A.


Output Format

Return an integer denoting the ( Total number of set bits in the binary representation of 
all the numbers from 1 to A )modulo 109 + 7.


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

    //This works - An optimized solution
    public static int solve2(int A)
    {
        long output = 0, mod = ((int)(Math.Pow(10, 9))) + 7;

        //Calculate the max power to the base 2 
        //short maxPower = Convert.ToInt16(Math.Log2(A));
        int maxPower = 0;

        int val = 1;
        while(val < A) {
            val *= 2;
            if(val > A) { break; }
            maxPower++;
        }

        long totalBitsInUnitPosition = Convert.ToInt64((Math.Pow(2, (double)maxPower) / 2));

        output += ((totalBitsInUnitPosition * maxPower)) % mod;

        int diff = A - ((int)(Math.Pow(2, maxPower)) - 1);

        if(diff < 0) {
            return Convert.ToInt32(output + 1);
        }

        output += diff;
        output += diff / 2;

        for (int i = maxPower - 1; i >= 1 ; i--) {

            int powerValue = (int)(Math.Pow(2, i));

            int bitsNotInGroups = diff % powerValue;
            int groupsOfSize2PowerI = diff / powerValue;

            //If Odd
            if(groupsOfSize2PowerI % 2 != 0) {
                output += bitsNotInGroups;
            }

            int groupsOf1s = groupsOfSize2PowerI / 2;

            output = output + powerValue * groupsOf1s;

            output = output % mod;
        }

        return Convert.ToInt32(output);
    }
}
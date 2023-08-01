/*
You are given three positive integers, A, B, and C.

Any positive integer is magical if divisible by either B or C.

Return the Ath smallest magical number. Since the answer may be very large, return modulo 109 + 7.

Note: Ensure to prevent integer overflow while calculating.

Problem Constraints
1 <= A <= 109

2 <= B, C <= 40000

Input Format
The first argument given is an integer A.

The second argument given is an integer B.

The third argument given is an integer C.

Output Format
Return the Ath smallest magical number. Since the answer may be very large, return modulo 109 + 7.

Example Input
Input 1:

 A = 1
 B = 2
 C = 3
Input 2:

 A = 4
 B = 2
 C = 3


Example Output
Output 1:

 2
Output 2:

 6

Example Explanation
Explanation 1:

 1st magical number is 2.
Explanation 2:

 First four magical numbers are 2, 3, 4, 6 so the 4th magical number is 6.
 */

public static class AthMagicalNumber
{
    public static int solve(int A, int B, int C)
    {
        long output = 0, mod = (int)(Math.Pow(10, 9) + 7);
        long multiplesCountTillMidForB = 0, multiplesCountTillMidForC = 0;

        long val = long.MaxValue, mid = val / 2, start = 1, end = val;
        long position = 0; int count = 1;

        int lcm = findLCM(C, B);

        while(start != end) {

            multiplesCountTillMidForB = mid / (long)B;

            multiplesCountTillMidForC = mid / (long)C;

            long commonMultiples = mid / lcm;

            position = multiplesCountTillMidForB + multiplesCountTillMidForC - commonMultiples ;

            if (A == position) { break; }
            else if (A > position) { start = mid; }
            else { end = mid;}

            mid = (start + end) / 2;
            count++;
        }

        int val1 = Convert.ToInt32(((B * multiplesCountTillMidForB) % mod));
        int val2 = Convert.ToInt32(((C * multiplesCountTillMidForC) % mod));

        if(val1 > val2) {
            output = val1;
        }
        else if (val1 < val2) {
            output = val2;
        }
        else {
            output = val1;
        }

        return Convert.ToInt32(output);
    }

    static int findLCM(int a, int b)
    {
        int lcm;

        lcm = (a*b) / findGCD(a, b);

        return lcm;
    }

    static int findGCD(int a, int b)
    {
        if(a == 0) { 
            return b; 
        }
        else if(b == 0) {
            return a;
        }

        if(a > b) {
            return findGCD(b, a % b);
        }
        else if(a < b) {
            return findGCD(a, b % a);
        }
        else {
            return a;
        }
    }
}
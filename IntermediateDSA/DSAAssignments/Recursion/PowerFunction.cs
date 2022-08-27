/*
Implement pow(A, B) % C.
In other words, given A, B and C, Find (AB % C).

Note: The remainders on division cannot be negative. In other words, make sure the answer you return is non-negative.

Problem Constraints
-109 <= A <= 109
0 <= B <= 109
1 <= C <= 109

Input Format
Given three integers A, B, C.

Output Format
Return an integer.

Example Input
A = 2, B = 3, C = 3

Example Output
2

Example Explanation
23 % 3 = 8 % 3 = 2

 */
public static class PowerFunction
{
    public static int pow(int A, int B, int C)
    {
        if (A == 0 && B == 0) { return 0; }

        if (B==0) { return 1; }

        int half = pow(A, B / 2, C);

        long ans = ((Convert.ToInt64(half) % Convert.ToInt64(C)) * (Convert.ToInt64(half) % Convert.ToInt64(C))%C);



        if (B % 2 == 0) {

            if (ans < 0) { ans = Convert.ToInt64(C) + ans; }

            return (int)ans;
        }
        else {

            ans = ((ans * (Convert.ToInt64(A) % Convert.ToInt64(C))) % C);

            if (ans < 0) { ans = Convert.ToInt64(C) + ans; }

            return (int)ans;
        }
    }
}
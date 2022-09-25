/*
Given two Integers A, B. You have to calculate (A ^ (B!)) % (1e9 + 7).

"^" means power,

"%" means "mod", and

"!" means factorial.

Problem Constraints
1 <= A, B <= 5e5

Input Format
First argument is the integer A

Second argument is the integer B

Output Format
Return one integer, the answer to the problem

Example Input
Input 1:

A = 1
B = 1
Input 2:

A = 2
B = 2


Example Output
Output 1:

1
Output 2:

4

Example Explanation
Explanation 1:

 1! = 1. Hence 1^1 = 1.
Explanation 2:

 2! = 2. Hence 2^2 = 4.
 */

public static class VeryLargePower
{

    //Use Fermat's little theorem to solve this A ^ (p-1) % P = 1
    public static int solve(int A, int B)
    {
        int output = 1, val = (int)(Math.Pow(10,9) + 7 );

        for (int i = 1; i <= B; i++) {

            output = (i * output) % (val-1);
        }

        int powRes = 1;
        for (int j = 1; j <=output; j++) {

            powRes = (A * powRes) % (val);
        }

        int res = (int)(Math.Pow(A,output)%val);

        return res;
    }
}
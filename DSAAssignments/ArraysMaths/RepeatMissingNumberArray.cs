/*There are certain problems which are asked in the interview to also check how you take care of overflows in your problem.
This is one of those problems.
Please take extra care to make sure that you are type-casting your ints to long properly and at all places. Try to verify if your solution works if number of elements is as large as 105

Food for thought :

Even though it might not be required in this problem, in some cases, you might be required to order the operations cleverly so that the numbers do not overflow.
For example, if you need to calculate n! / k! where n! is factorial(n), one approach is to calculate factorial(n), factorial(k) and then divide them.
Another approach is to only multiple numbers from k + 1 ... n to calculate the result.
Obviously approach 1 is more susceptible to overflows.
You are given a read only array of n integers from 1 to n.

Each integer appears exactly once except A which appears twice and B which is missing.

Return A and B.

Note: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

Note that in your output A should precede B.

Example:

Input:[3 1 2 5 3] 

Output:[3, 4] 

A = 3, B = 4
 */
public static class RepeatMissingNumberArray
{
    public static List<int> repeatedNumber(List<int> A)
    {
        int[] res = new int[2]; int N = A.Count;

        int xor1 = 0, xor2 = 0, x = 1;
        for (int i = 0; i < N; i++,x++) {
            xor1 ^= A[i];
            xor2 ^= x;
        }

        int xor = xor1 ^ xor2;

        //Find the first set bit
        int k = 1, j = 1;
        while( (xor & k) != 1) {

           k = k << j++;
        }

        res[0] = 0; j = j - 1; x = 1;
        for (int i = 0; i < A.Count; i++,x++) {

            if ((A[i] & (1<<j)) ==1) {
                res[0] ^= A[i];
            }
            else {
                res[1] ^= A[i];
            }

            if ((x & (1 << j)) != 1) {
                res[1] ^= x;
            }
            else {
                res[0] ^= x;
            }
        }

        return res.ToList();
    }

    public static List<int> repeatedNumber2(List<int> A)
    { 
        List<int> res = new List<int>();

        int n = A.Count, p=0, q=0, c=0,d=0, a, b;

        long sum = 0, sumsq=0;
        for (int i = 0; i < A.Count; i++) {
            sum += A[i];
            sumsq += Convert.ToInt32(Math.Pow(A[i], 2));
        }

        a = Convert.ToInt32(((n * (n + 1) * (2 * n + 1)) / 6) - sumsq);
        b = Convert.ToInt32(((n * (n + 1)) / 2) - sum);

        p = a / b;
        q = b;

        c = (p + q) / 2;
        d = p - c;
               
        
        res.Add(d);
        res.Add(c);

        return res;
    }

}
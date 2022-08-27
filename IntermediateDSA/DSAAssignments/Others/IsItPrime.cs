/*
Given an integer A, you have to tell whether it is a prime number or not.

A prime number is a natural number greater than 1 which is divisible only by 1 and itself.

1 <= A <= 10^6

Print YES if A is a prime, else print NO.
 */

public static class IsItPrime
{
    public static void Operation1(int N)
    {
        int factorsCount = 0;

        for (int i = 1; i*i <= N; i++)
        {
            if (N % i == 0)
            {
                if (i == N / i) { factorsCount++; }

                else{
                    factorsCount = factorsCount + 2;
                }
            }
        }

        if (factorsCount == 2) { 
            Console.WriteLine("YES");
        }
        else { 
            Console.WriteLine("NO"); 
        }
    }
}
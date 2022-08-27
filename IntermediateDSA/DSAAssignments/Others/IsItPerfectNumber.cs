/*
You are given N positive integers.

For each given integer A, you have to tell whether it is a perfect number or not.

Perfect number is a positive integer which is equal to the sum of its proper positive divisors.

1 <= N <= 10
1 <= A <= 106

Input Format:

First line of the input contains a single integer N.

Each of the next N lines contains a single integer A.


Output Format:

In a seperate line, print YES if a given integer is perfect, else print NO.

Input:
 2
 4
 6 

Output:
 NO
 YES 
 */
public static class IsItPerfectNumber
{
    public static void Operation1(int N, List<int> inputs)
    {
        for (int i = 0; i < N; i++)
        {
            if (IsPerfect(inputs[i])) { 
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    public static bool IsPerfect(int number)
    {
        bool isPerfect = false; int sum = 0;

        for (int i = 1; i*i <= number; i++)
        {
            if (number % i == 0)
            {
                if ((i == number / i) || (number/i == number))
                {
                    sum = sum + i ;
                }
                else
                {
                    sum = sum + i + (number / i);
                }
            }
        }

        if (number == sum) { isPerfect = true; }

        return isPerfect;
    }
}
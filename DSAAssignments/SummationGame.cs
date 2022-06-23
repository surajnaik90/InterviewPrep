/*
Write a program to find sum all Natural numbers from 1 to N where you have to take N as input from user

1 <= N <= 1000

Input Format

A single line representing N

Output Format

A single integer showing sum of all Natural numbers from 1 to N

Example Input

Input 1:

5
Input 2:

10


Example Output

Output 1:

15
Output 2:

55
 */

public static class SummationGame
{
    public static void Operation1()
    {
        string number = Console.ReadLine();
        int N = Convert.ToInt32(number);
        int sum = 0;

        sum = (N * (N + 1)) / 2;

        Console.WriteLine(sum);
    }
}
﻿/*
For a given number A, print its multiplication table having the first 10 multiples.

Problem Constraints
1 <= A <= 1000

Input Format
First line contains a single integer A.

Output Format
Print 10 lines, ith line containing ith multiple.

Example Input
Input 1:

 2 
Input 2:

 3 


Example Output
Output 1:

 2 * 1 = 2 
 2 * 2 = 4 
 2 * 3 = 6 
 2 * 4 = 8 
 2 * 5 = 10 
 2 * 6 = 12 
 2 * 7 = 14 
 2 * 8 = 16 
 2 * 9 = 18 
 2 * 10 = 20 
Output 2:

 3 * 1 = 3 
 3 * 2 = 6 
 3 * 3 = 9 
 3 * 4 = 12 
 3 * 5 = 15 
 3 * 6 = 18 
 3 * 7 = 21 
 3 * 8 = 24 
 3 * 9 = 27 
 3 * 10 = 30 
 */

public static class MultiplicationTable
{
    public static void Operation1()
    {
        string input = Console.ReadLine();

        int number = Convert.ToInt32(input);

        if(!(number>=1 && number <= 1000)) { return; }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + number*i);
        }
    }
}
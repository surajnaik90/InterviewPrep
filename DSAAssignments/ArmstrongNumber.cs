/*
You are given an integer N you need to print all the Armstrong Numbers between 1 to N.

If sum of cubes of each digit of the number is equal to the number itself,
then the number is called an Armstrong number.

For example, 153 = ( 1 * 1 * 1 ) + ( 5 * 5 * 5 ) + ( 3 * 3 * 3 ).


Problem Constraints

1 <= N <= 500

Input Format

First and only line of input contains an integer N.

Output Format

Output all the Armstrong numbers in range [1,N] each in a new line.

Example Input

Input 1:

 5
Input 2:

 200


Example Output

Output 1:

1
Output 2:

1
153


Example Explanation

Explanation 1:

1 is an armstrong number.
Explanation 2:

1 and 153 are armstrong number under 200.
 */

public static class ArmstrongNumber
{
    public static int Operation1(int N)
    {
        string? input = Console.ReadLine();
        int number = Convert.ToInt32(input); int sum = 0, reminder=0;

        if(!(number >=1 && number <=500)) { return 0; }

        List<int> output = new List<int>() {};

        for (int i = 1; i <= number; i++)
        {
            int temp = i; sum = 0; reminder = temp % 10;

            while (temp != 0)
            {
                sum = sum + Convert.ToInt32(Math.Pow(reminder, 3));

                temp = temp / 10;

                reminder = temp % 10;
            }

            if (i == sum) {
                output.Add(i);
            }
        }

        for (int i = 0; i < output.Count; i++)
        {
            Console.WriteLine(output[i]);
        }

        return 0;
    }
}
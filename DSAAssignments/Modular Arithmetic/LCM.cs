/*
Write a program to input an integer T and then for each test case input two integers A and B in two different lines and then print T lines containing Least Common Multiple (LCM) of two given 2 numbers A and B.

LCM of two integers is the smallest positive integer divisible by both.

Problem Constraints
1 <= T <= 1000

1 <= A,B <= 1000

Input Format
In first-line input T which means number of test cases.

Next 2T lines contains input A and B for each testcase.
First line of each testcase contain an integer A and second line of the testcase contains input B.

Output Format

T lines each containing an integer representing LCM of A & B.

Example Input
Input 1:
3
2
3
9
6
2
6

Example Output
Output 1:
6
18
6

Example Explanation
Explanation:

 In first testcase 6 is the smallest positive integer which is divisible by both 2 (2 * 3 = 6) and 3 (3 * 2 = 6).
 In second testcase 18 is the smallest positive integer which is divisible by both 9 (9 * 2 = 18) and 6 (6 * 3 = 18).
 In third testcase  6 is the smallest positive integer which is divisible by both 2 (2 * 3 = 6) and 6 (6 * 1 = 6).
 */

public static class LCM
{
    public static void Operation1()
    {
        int ans = FindLCM2(4, 5);
        int ans2 = FindLCM2(3, 9);

        //Read test cases count
        int T = Convert.ToInt32(Console.ReadLine());

        //Read inputs for each test case
        int[,] inputs = new int[T, 2];
        for (int i = 0; i < T; i++) {
            inputs[i, 0] = Convert.ToInt32(Console.ReadLine());
            inputs[i,1]= Convert.ToInt32(Console.ReadLine());
        }

        //Find the LCM for each test case and print it.
        for (int i = 0; i < T; i++) {
            Console.WriteLine(FindLCM2(inputs[i, 0], inputs[i,1]));
        }
    }

    //Function to find the LCM - Time Limit Exceeds for large inputs.
    static int FindLCM1(int A, int B)
    {
        int a = A, b = B, n = 2, output=1;
        bool increment = true, multiply = false;

        while(a>1 && b>1) {

            if (a % n == 0) {
                multiply = true;
                a = a / n;
                if (a % n == 0) { increment = false; }
            }

            if(b%n== 0) {
                multiply = true;
                b = b / n;
                if (b % n == 0) { increment = false; }
            }

            if (multiply) { output *= n; }

            if(increment) { n += 1; }
        }

        output = output * a * b;

        return output;
    }

    //Optmized approach
    static int FindLCM2(int A, int B)
    {
        if (A == B) { return A; }

        int n = 2;

        int big = A > B ? A : B;
        int small = A < B ? A : B;

        int value = big;

        while (true) {

            if (value % small == 0) {
                return value;
            }

            value = big * n; n++;
        }
    }
}
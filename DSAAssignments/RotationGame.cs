/*
Problem Description
Given an integer array A of size N and an integer B, you have to print the same array after rotating it B times towards the right.


Problem Constraints
1 <= N <= 106
1 <= A[i] <=108
1 <= B <= 109


Input Format
There are 2 lines in the input

Line 1: The first number is the size N of the array A. Then N numbers follow which indicate the elements in the array A.

Line 2: A single integer B.


Output Format
Print array A after rotating it B times towards the right.


Example Input
Input 1 :
4 1 2 3 4
2


Example Output
Output 1 :
3 4 1 2


Example Explanation
Example 1 :

N = 4, A = [1, 2, 3, 4] and B = 2.

Rotate towards the right 2 times - [1, 2, 3, 4] => [4, 1, 2, 3] => [3, 4, 1, 2]

Final array = [3, 4, 1, 2]

 */

public static class RotationGame
{
    public static void Operation1()
    {
        Console.WriteLine("Please enter the array size N & the array & then followed by B in the new line");
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        int N = Convert.ToInt32(input1.Split()[0]);

        int[] arr = new int[N];
        for (int i = 0; i < N; i++) {
            arr[i] = Convert.ToInt32(input1.Split(' ')[i+1]);
        }

        int B = Convert.ToInt32(input2);
        int[] newArr = new int[N];

        int pointer = B % N;

        for (int i = N-pointer,k=0; i < N; i++,k++)
        {
            newArr[k] = arr[i];
        }

        for (int j = 0, k=N-pointer; j < N - pointer; j++,k++)
        {
            newArr[k] = arr[j];
        }

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(newArr[i]);
        }
    }
}
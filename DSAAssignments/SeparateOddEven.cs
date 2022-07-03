/*
You are given an array of integers A of size N.
Return the difference between the maximum among all even numbers of A and the minimum among all odd numbers in A.

Problem Constraints
2 <= N <= 1e5
-1e9 <= A[i] <= 1e9
There is atleast 1 odd and 1 even number in A

Input Format
The first argument given is the integer array, A.

Output Format
Return maximum among all even numbers of A - minimum among all odd numbers in A.

Example Input
Input 1:

 A = [0, 2, 9]
Input 2:

 A = [5, 17, 100, 1]


Example Output
Output 1:

-7
Output 2:

99

Example Explanation
Explanation 1:

Maximum of all even numbers = 2
Minimum of all odd numbers = 9
ans = 2 - 9 = -7
Explanation 2:

Maximum of all even numbers = 100
Minimum of all odd numbers = 1
ans = 100 - 1 = 99
 */

public static class SeparateOddEven
{
    public static void Operation1()
    {
        int T = Convert.ToInt32(Console.ReadLine());
        List<List<int>> inputs = new List<List<int>>();
        List<List<int>> outputs = new List<List<int>>();

        for (int i = 0; i < T; i++)
        {
            List<int> arr = new List<int>();

            arr.Add(Convert.ToInt32(Console.ReadLine()));
            string[] arrInput = Console.ReadLine().Split();

            for (int j = 0; j < arr[0]; j++)
            {
                arr.Add(Convert.ToInt32(arrInput[j]));
            }

            inputs.Add(arr);
        }

        for (int i = 0; i < T; i++)
        {
            List<int> eArr = new List<int>();
            List<int> oArr = new List<int>();

            for (int j = 1; j < inputs[i].Count; j++)
            {
                if (inputs[i][j] % 2 == 0) {
                    eArr.Add(inputs[i][j]);
                }
                else {
                    oArr.Add(inputs[i][j]);
                }
            }

            outputs.Add(oArr);
            outputs.Add(eArr);
        }

        for (int i = 0; i < outputs.Count; i++)
        {
            for (int j = 0; j < outputs[i].Count; j++)
            {
                Console.Write(outputs[i][j]+" ");
            }
            Console.WriteLine();
        }
    }
}
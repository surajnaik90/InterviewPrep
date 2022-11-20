/*
Given an integer A, you have to find the Ath Perfect Number.

A Perfect Number has the following properties:

It comprises only 1 and 2.

The number of digits in a Perfect number is even.

It is a palindrome number.

For example, 11, 22, 112211 are Perfect numbers, where 123, 121, 782, 1 are not.

Problem Constraints
1 <= A <= 100000

Input Format
The only argument given is an integer A.

Output Format
Return a string that denotes the Ath Perfect Number.

Example Input
Input 1:

 A = 2
Input 2:

 A = 3


Example Output
Output 1:

 22
Output 2:

 1111


Example Explanation
Explanation 1:

First four perfect numbers are:
1. 11
2. 22
3. 1111
4. 1221
Explanation 2:

First four perfect numbers are:
1. 11
2. 22
3. 1111
4. 1221
 */

using System.Text;

public static class PerfectNumbers
{
    public static string solve(int A)
    {
        Queue<string> q = new Queue<string>();
        
        q.Enqueue("11"); q.Enqueue("22");

        string number = string.Empty; int count = 2;

        for (int i = 1; i <= A; i++) {

            number = q.Dequeue(); count--;

            if (count == A) { return number; }
            
            int mid = number.Length / 2;
            string strLeft = number.Substring(0, mid);
            string strRight = number.Substring(mid, mid);

            StringBuilder sb = new StringBuilder();
            sb.Append(strLeft);
            sb.Append("11");
            sb.Append(strRight);
            q.Enqueue(sb.ToString());
            count++;

            sb = new StringBuilder();
            sb.Append(strLeft);
            sb.Append("22");
            sb.Append(strRight);
            q.Enqueue(sb.ToString());
            count++;
        }

        return number;
    }
}
/*Given an array A of non-negative integers, arrange them such that they form the largest number.

Note: The result may be very large, so you need to return a string instead of an integer.

Problem Constraints
1 <= len(A) <= 100000
0 <= A[i] <= 2*109

Input Format
The first argument is an array of integers.

Output Format
Return a string representing the largest number.

Example Input
Input 1:

 A = [3, 30, 34, 5, 9]
Input 2:

 A = [2, 3, 9, 0]

Example Output
Output 1:

 "9534330"
Output 2:

 "9320"

Example Explanation
Explanation 1:

Reorder the numbers to [9, 5, 34, 3, 30] to form the largest number.
Explanation 2:

Reorder the numbers to [9, 3, 2, 0] to form the largest number 9320.
*/

public static class LargestInteger
{
    public static string solve(List<int> A)
    {
        A.Sort(new NumComparer()); 

        string output = string.Empty; int count = 0;
        for (int i = 0; i < A.Count; i++) {

            if (A[i]==0) { count++; }

            output += A[i];
        }

        if (count==A.Count) { return "0"; }

        return output;
    }

    public class NumComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            string s1 = x.ToString() + y.ToString();
            string s2 = y.ToString() + x.ToString();

            if (s1.CompareTo(s2) < 0) {
                return -1;
            } 
            else if (s1.CompareTo(s2) == 0) {
                return 0;
            }
            else {
                return 1;
            }
        }
    }


    // TIME LIMIT EXCEEDED
    class Comparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int value1, value2, i;
            string x1 = x.ToString(), y1 = y.ToString();

            string s1 = x1 + y1, s2 = y1 + x1;

            for (i = 0; i < s1.Length; i++) { 
                if (s1[i] != s2[i]) { break; }
            }

            if(i==s1.Length) { return 0; }

            value1 = Convert.ToInt32(s1[i]);
            value2 = Convert.ToInt32(s2[i]);

            if (value1>value2) {
                return -1;
            }
            else{
                return 1;
            }
        }
    }
}
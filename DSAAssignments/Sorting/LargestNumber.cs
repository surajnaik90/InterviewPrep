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

using System.Text;

public static class LargestInteger
{
    public static string solve(List<int> A)
    {
        List<string> list = new List<string>();

        for (int i = 0; i < A.Count; i++) { 
            list.Add(A[i].ToString());
        }

        list.Sort(new NumComparer2());

        string output = string.Empty; int count = 0;
        for (int i = 0; i < list.Count; i++) {

            if (A[i]=='0') { count++; }

            output += list[i];
        }

        if (count==A.Count) { return "0"; }

        return output;
    }

    private class NumComparer2 : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            StringBuilder s1 = new StringBuilder();
            StringBuilder s2 = new StringBuilder();

            s1.Append(x);
            s1.Append(y);

            s2.Append(y);
            s2.Append(x);

            string n = s1.ToString(), m = s2.ToString();

            if (m.CompareTo(n) < 0) {
                return -1;
            }
            else if (m.CompareTo(n) == 0) {
                return 0;
            }
            else {
                return 1;
            }
        }
    }

    private class NumComparer : IComparer<int>
    {
        public int Compare(int x, int y) {

            if(x==y) { return 0; }

            StringBuilder s1 = new StringBuilder();
            StringBuilder s2 = new StringBuilder();

            s1.Append(x.ToString());
            s1.Append(y.ToString());
            
            s2.Append(y.ToString());
            s2.Append(x.ToString());

            string n = s1.ToString(), m = s2.ToString();            

            if (m.CompareTo(n) < 0) {
                return -1;
            } 
            else if (m.CompareTo(n) == 0) {
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
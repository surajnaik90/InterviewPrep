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

public static class MarksSort
{
    public static List<string> solve(List<string> A)
    {
        List<string> result = new List<string>();

        result.Sort();

        for (int i = 0; i < A.Count; i++)
        {

            result.Add(A[i]);
        }

        result.Sort(new MarksComparator());

        return result;
    }

    public class MarksComparator : IComparer<string>
    {

        public int Compare(string x, string y)
        {

            int i = 0;

            int m;
            for (i = 0; i < x.Length; i++)
            {

                if (x[i] >= 48 && x[i] <= 57)
                {
                    break;
                }
            }
            m = Convert.ToInt32(x.Substring(i));

            int n;
            for (i = 0; i < y.Length; i++)
            {

                if (y[i] >= 48 && y[i] <= 57)
                {
                    break;
                }
            }
            n = Convert.ToInt32(y.Substring(i));

            if (m > n)
            {
                return 1;
            }
            else if (m == n)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
/*
You're given a read-only array of N integers. Find out if any integer occurs more than N/3 times in the array in 
linear time and constant additional space.
If so, return the integer. If not, return -1.

If there are multiple solutions, return any one.

Problem Constraints
1 <= N <= 7*105
1 <= A[i] <= 109

Input Format
The only argument is an integer array A.

Output Format
Return an integer.

Example Input
[1 2 3 1 1]

Example Output
1
Example Explanation
1 occurs 3 times which is more than 5/3 times.
 */
public static class NBy3RepeatNumber
{
    public static int solve(List<int> A)
    {
        int num1 = int.MinValue, num2 = int.MinValue, f1 = 0, f2 = 0;

        for (int i = 0; i < A.Count; i++) {

            if (A[i] == num1) { 
                f1++;
            }
            else if (A[i] == num2) {
                f2++;
            }
            else if (num1 == int.MinValue) {
                num1 = A[i];
                f1 = 1;
            }
            else if (num2 == int.MinValue) {
                num2 = A[i];
                f2 = 1;
            }
            else {
                f1--;
                f2--;

                if (f1 == 0) {
                    num1 = int.MinValue;
                }
                if(f2==0) {
                    num2 = int.MinValue;
                }
            }

        }

        int count1 = 0, count2=0;
        for (int i = 0; i < A.Count; i++) {

            if (A[i] == num1) {
                count1++;
            }

            if (A[i]==num2) {
                count2++;
            }
        }

        if(count1 > A.Count / 3) { 
            return num1;
        }
            
        if(count2 > A.Count / 3) {
            return num2;
        }

        return -1;
    }
}
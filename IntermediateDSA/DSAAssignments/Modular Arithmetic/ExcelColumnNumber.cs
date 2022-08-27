/* Given a column title as appears in an Excel sheet, return its corresponding column number.

Problem Constraints
1 <= length of the column title <= 5

Input Format
The only argument is a string that represents the column title in the excel sheet.

Output Format
Return a single integer that represents the corresponding column number.

Example Input
Input 1:

 AB
Input 2:

 BB

Example Output
Output 1:

 28
Output 2:

 54

Example Explanation
Explanation 1:

 A -> 1
 B -> 2
 C -> 3
 ...
 Z -> 26
 AA -> 27
 AB -> 28
Explanation 2:

 A -> 1
 B -> 2
 C -> 3
 ...
 Z -> 26
 AA -> 27
 AB -> 28
 ...
 AZ -> 52
 BA -> 53
 BB -> 54
 */
public static class ExcelColumnNumber
{
    public static int titleToNumber(string A)
    {
        int N = A.Length, sum=0;

        if(N==1) { 
            return ((Convert.ToInt32(A[0])) % 64);
        }

        int count = N;
        while (count >= 1) {
            sum += Convert.ToInt32(Math.Pow(26, count - 1));
            count--;
        }

        for (int i = N-1, j=0; i >=0 ; i--,j++) {
            sum += Convert.ToInt32(Math.Pow(26, j)) * (((Convert.ToInt32(A[i])) % 64)-1);
        }

        return sum;
    }
}
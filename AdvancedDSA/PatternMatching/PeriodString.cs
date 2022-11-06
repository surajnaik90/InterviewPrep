/*
You are given a string A of length N consisting of lowercase alphabets. Find the period of the string.

Period of the string is the minimum value of k (k >= 1), that satisfies A[i] = A[i % k] for all valid i.

Problem Constraints
1 <= N <= 106

Input Format
First and only argument is a string A of length N.

Output Format
Return an integer, denoting the period of the string.

Example Input
Input 1:

 A = "abababab"
Input 2:

 A = "aaaa"


Example Output
Output 1:

 2
Output 2:

 1

Example Explanation
Explanation 1:

 Period of the string will be 2: 
 Since, for all i, A[i] = A[i%2]. 
Explanation 2:

 Period of the string will be 1.
 */

public static class PeriodString
{
    public static int solve(string A)
    {
        int size = 1, length = A.Length, l = 0, r = 1, count;

        string a = "1001", b = "1001";

        

        while (A[r] != A[l]) {
            r++; size++;
        }

        while(r < length) {
            
            if (A[r] == A[l]) {

                l++; r++; count = 1;

                if (r >= length) { break; }

                while (count != size) {

                    if (A[r] == A[l]) {
                        count++; l++; r++;

                        if( r >= length) { break; }
                    }
                    else {
                        return length;
                    }
                }
            }
            else {
                return length;
            }
        }

        return size;
    }
}
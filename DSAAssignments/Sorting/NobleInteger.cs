/*Given an integer array A, find if an integer p exists in the array such that the number of integers greater 
 * than p in the array equals p.

Problem Constraints
1 <= |A| <= 2*105
1 <= A[i] <= 107

Input Format
First and only argument is an integer array A.

Output Format
Return 1 if any such integer p is present else, return -1.

Example Input
Input 1:

 A = [3, 2, 1, 3]
Input 2:

 A = [1, 1, 3, 3]

Example Output
Output 1:

 1
Output 2:

 -1

Example Explanation
Explanation 1:

 For integer 2, there are 2 greater elements in the array..
Explanation 2:

 There exist no integer satisfying the required conditions.
*/

public static class NobleInteger
{
    public static int solve(List<int> A)
    {
        int N = A.Count;

        A.Sort();

        int[] countArr = new int[N]; int count = 1;

        if (countArr[N-1] == A[N-1]) { return 1; }

        for (int i = N-2; i >= 0; i--) {

            if (A[i] == A[i+1]) {
                countArr[i] = countArr[i + 1];
            }
            else {
                countArr[i] = count;
            }

            if (countArr[i] == A[i]) {
                return 1;
            }

            count++;
        }

        return -1;
    }
}
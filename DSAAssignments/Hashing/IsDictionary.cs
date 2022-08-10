/*
1 <= N, length of each word <= 105
Sum of the length of all words <= 2 * 106

Input Format
The first argument is a string array A of size N.
The second argument is a string B of size 26, denoting the order.

Output Format
Return 1 if and only if the given words are sorted lexicographically in this alien language else, 
return 0.

Example Input
Input 1:

 A = ["hello", "scaler", "interviewbit"]
 B = "adhbcfegskjlponmirqtxwuvzy"
Input 2:

 A = ["fine", "none", "no"]
 B = "qwertyuiopasdfghjklzxcvbnm"

Example Output
Output 1:

 1
Output 2:

 0
Example Explanation
Explanation 1:

 The order shown in string B is: h < s < i for the given words. So return 1.
Explanation 2:

 "none" should be present after "no". Return 0.
 */
public static class IsDictionary
{
    public static int solve(List<string> A, string B)
    {
        List<int> result = new List<int>();
        Dictionary<long, int> prefixIndexMap = new Dictionary<long, int>();
        long sum = 0;

        

        return 0;
    }
}
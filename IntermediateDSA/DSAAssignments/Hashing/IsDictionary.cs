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
        Dictionary<char, int> hashmap = new Dictionary<char, int>();

        hashmap.Add('0', 0);
        for (int i = 0; i < B.Length; i++) {
            hashmap.Add(B[i], i+1);
        }

        string prev = A[0];
        for (int i = 1; i < A.Count; i++) {

            if (hashmap[prev[0]] > hashmap[A[i][0]]) {
                return 0;
            }
            else if (hashmap[prev[0]] < hashmap[A[i][0]]) {
                prev = A[i];
                continue;
            }
            else {

                string p = prev, n=string.Empty;
                if (prev.Length < A[i].Length) {
                  p =  prev.PadRight(prev.Length + (A[i].Length - prev.Length), '0');
                }
                else if (prev.Length > A[i].Length) {
                   n = A[i].PadRight(A[i].Length + (prev.Length - A[i].Length), '0');
                }
                else { n = A[i]; }

                int k = 0;
                while (k<=p.Length) {
                    
                    if(hashmap[p[k]] > hashmap[n[k]]) {
                        return 0;
                    }
                    else if (hashmap[p[k]] < hashmap[n[k]]) {
                        break;
                    }
                    k++;
                }
            }
            prev = A[i];
        }

        return 1;
    }
}
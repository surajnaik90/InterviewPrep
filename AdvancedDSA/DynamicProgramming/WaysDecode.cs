/*
A message containing letters from A-Z is being encoded to numbers using the following mapping:

'A' -> 1
'B' -> 2
...
'Z' -> 26
Given an encoded message denoted by string A containing digits, 
determine the total number of ways to decode it modulo 109 + 7.

Problem Constraints
1 <= length(A) <= 105

Input Format
The first and the only argument is a string A.

Output Format
Return an integer, representing the number of ways to decode the string modulo 109 + 7.

Example Input
Input 1:

 A = "12"
Input 2:

 A = "8"

Example Output
Output 1:
 2
Output 2:

 1

Example Explanation
Explanation 1:

 Given encoded message "8", it could be decoded as only "H" (8).
 The number of ways decoding "8" is 1.
Explanation 2:

 Given encoded message "12", it could be decoded as "AB" (1, 2) or "L" (12).
 The number of ways decoding "12" is 2.

 */

using System.Collections;


public static class WaysDecode
{
    public static int solve(string A)
    {
        Dictionary<string, char> map = 
            new Dictionary<string, char>();

        Dictionary<string, long> dp = new Dictionary<string, long>();
        int mod = (int)(Math.Pow(10, 9) + 7);

        short code = 65; string str = string.Empty;
        char character;

        for (int i = 1; i <= 26; i++) {

            str = Convert.ToString(i);
            character = (char)code++;

            map.Add(str, character);
        }

        int ans = Convert.ToInt32( (waysDecode2(-1, A, map, dp, mod))%mod);

        //int ans = waysDecode(-1, A, map);

        return ans;
    }

    //Using Backtracking - It gives stack overflow exception
    static int waysDecode(int index, string str,
        Dictionary<string,char> map)
    {
        int length = str.Length, ways1 = 0, ways2 = 0;
        int mod = (int)(Math.Pow(10,9) + 7);

        if (index > (length - 1)) {
            return 1;
        }

        if( ((index+1) > length) || ((index+2)> length)) {
            return 1;
        }

        string substr = str.Substring(index+1, 1);

        if (map.ContainsKey(substr)) {
            ways1 += waysDecode(index + 1, str, map);
        }
        else {
            return (0 + ways2) % mod;
        }

        try {
            substr = str.Substring(index + 1, 2);
        }
        catch (Exception ex) {
            return (ways1 + 0) % mod;
        }

        if (map.ContainsKey(substr)) {
            ways2 += waysDecode(index + 2, str, map);
        }
        else {
            return (ways1 + 0) % mod;
        }

        return (ways1 + ways2)%mod;
    }

    //Therefore use Dynamic programming - Optimal solution
    static long waysDecode2(int index, string str,
        Dictionary<string, char> map, Dictionary<string,long> dp, int mod)
    {
        int length = str.Length; long ways1 = 0, ways2 = 0;        

        if ((index > (length - 1)) || 
            ((index + 1) > length) || 
            ((index + 2) > length))
        {
            return 1;
        }

        string substr = str.Substring(index + 1, 1);
        string key = Convert.ToString(index+1);

        if (map.ContainsKey(substr)) {

            if (dp.ContainsKey(key)) {
                ways1 = dp[key];
            }
            else {
                ways1 += waysDecode2(index + 1, str, map, dp, mod);
                dp[key] = ways1;
            }
        }
        else {
            return (ways1 + ways2) % mod;
        }                                                                                                                                                                                                

        try {
            substr = str.Substring(index + 1, 2);
        }
        catch (Exception ex) {
            key = Convert.ToString(index + 1) + Convert.ToString(index + 2);
            dp[key] = 0;
            return (ways1 + ways2) % mod;
        }

        key = Convert.ToString(index + 1) + Convert.ToString(index + 2);

        if (map.ContainsKey(substr)) {

            if (dp.ContainsKey(key)) {
                ways2 = dp[key];
            }
            else {
                ways2 += waysDecode2(index + 2, str, map, dp, mod);
                dp[key] = ways2;
            }
        }
        else {
            return (ways1 + ways2) % mod;
        }

        return (ways1 + ways2) % mod;
    }
}
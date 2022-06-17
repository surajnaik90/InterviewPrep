/*Given a string s, find the length of the longest substring without repeating characters.

    Input: s = "abcabcbb"
    Output: 3
    Explanation: The answer is "abc", with the length of 3.
*/
public static class LongestSubstring
{
    public static int Operation1(string str)
    {
        int len = str.Length; int output = 0, mid = len/2, count =0;
        string substr = string.Empty;       

        for (int i = 0; i < len; i++)
        { 
            substr = str[i].ToString();

            for (int j = i+1; j < len; j++)
            {
                if (!(substr.Contains(str[j]))) {
                    substr = string.Concat(substr, str[j]);
                }
                else { break; }
            }

            count = substr.Length;
            if (count >= output) {
                output = count;
            }

            if(count > (len - (i+1))) { break;}
        }

        return output;
    }
}
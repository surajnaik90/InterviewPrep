/*Given a string s, return the longest palindromic substring in s.

    Input: s = "babad"
    Output: "bab"
    Explanation: "aba" is also a valid answer.

    Input: s = "cbbd"
    Output: "bb"
*/
public static class LongestPalindrome
{
    public static string Operation(string str)
    {
        if(str.Length == 0) { return string.Empty; }

        if(str.Length == 1) { return str; }
        
        string output = string.Empty; string substr = string.Empty;
        Dictionary<string, int> palindromes = new Dictionary<string, int>();

        for (int i = 0; i < str.Length; i++)
        {
            substr = str[i].ToString();
            
            if (!(palindromes.ContainsKey(substr)))
            {
                if (IsPalindrome(substr))
                {
                    palindromes.Add(substr, substr.Length);
                }
            }            

            for (int j = i+1; j < str.Length; j++)
            {
                substr = string.Concat(substr, str[j]);
                if (!(palindromes.ContainsKey(substr)))
                {
                    if (IsPalindrome(substr))
                    {
                        palindromes.Add(substr, substr.Length);
                    }
                }
            }
        }

        if(palindromes.Count > 0)
        {
            palindromes = palindromes.OrderByDescending(val => val.Value).ToDictionary(k=>k.Key,va=>va.Value);
            output = palindromes.ElementAt(0).Key;
        }
        else
        {
            output=string.Empty;
        }
        return output;
    }

    private static bool IsPalindrome(string str)
    {
        if(str.Length == 1) { return true; }

        bool result = true;
        int count = str.Length / 2, j = str.Length - 1;

        for (int i = 0; i < count; i++)
        {
            if (str[i] == str[j--]) 
            { 
                continue; 
            }
            else
            {
                result = false;
            }
        }

        return result;
    }
}
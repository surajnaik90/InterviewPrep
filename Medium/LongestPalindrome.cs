/*Given a string s, return the longest palindromic substring in s.

    Input: s = "babad"
    Output: "bab"
    Explanation: "aba" is also a valid answer.

    Input: s = "cbbd"
    Output: "bb"
*/
public static class LongestPalindrome
{

    //This operation takes around 7000ms to execute which is insane.
    public static string Operation1(string str)
    {
        if(str.Length == 0) { return string.Empty; }
        
        string output = string.Empty; string substr = string.Empty;
        List<string> possiblePalindromes = new List<string>();
        Dictionary<string, int> palindromes = new Dictionary<string, int>();

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i; j < str.Length; j++)
            {
                substr = str.Substring(i, j-i+1);

                if (i == j) { 
                    substr = string.Concat("", str[i]);
                }

                if ((str[i] == str[j]) && (!(possiblePalindromes.Contains(substr)))) 
                {
                    possiblePalindromes.Add(substr);
                }
            }
        }

        int count = 0;
        for (int i = 0; i < possiblePalindromes.Count; i++)
        {
            if (IsPalindrome(possiblePalindromes[i])) {
                if(count < possiblePalindromes[i].Length) {
                    output = possiblePalindromes[i];
                    palindromes.Add(possiblePalindromes[i], possiblePalindromes[i].Length);
                    count = possiblePalindromes[i].Length;
                }
            }
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
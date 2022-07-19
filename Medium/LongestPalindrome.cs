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


    //Slightly better version. But still time limit exceeds. Avoid for loops as much as possible.
    //The below operation is better than operation1. THis operation executed 80 more test cases (total 125)
    //as compared to 45 testcases on leetcode.
    public static string Operation2(string str)
    {
        if (str.Length == 0) { return string.Empty; }

        string output = string.Empty; string substr = string.Empty;
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i; j < str.Length; j++)
            {
                substr = str.Substring(i, j - i + 1);

                if (i == j)
                {
                    substr = string.Concat("", str[i]);
                }

                if (str[i] == str[j])
                {
                    if (IsPalindrome(substr))
                    {
                        if (count < substr.Length)
                        {
                            output = substr;
                            count = substr.Length;
                        }
                    }
                }
            }
        }
        return output;
    }

    public static string Operation3(string str)
    {
        if (str.Length == 0) { return string.Empty; }

        string output = string.Empty; string substr = string.Empty;
        Dictionary<char, int> vault = new Dictionary<char, int>();
        int count = 0; bool flag;
        List<string> palindromes = new List<string>();

        for (int i = 0; i < str.Length; i++)
        {
            vault.Clear(); flag = false;

            for (int j = i; j < str.Length; j++)
            {
                substr = str.Substring(i, j - i + 1); flag = false;

                if (vault.ContainsKey(str[j])) { ++vault[str[j]]; }

                else { vault.Add(str[j], 1); }

                if (str[i] == str[j])
                {
                    if ((substr.Length % 2 == 0) && (!(vault.Values.Contains(1))) &&
                        (!(vault.Where(val => val.Value % 2 == 1).Count()>=1))) {

                        flag = true;
                        palindromes.Add(substr);
                    }
                    else if ((substr.Length % 2 == 1)) {

                        int onesCount = vault.Where(val => val.Value==1).Count();

                        int others = vault.Where(val => val.Value % 2 == 1).Count();

                        if(onesCount > 1 || others > 1 ) { flag = false; }
                    }

                    if (flag)
                    {
                        if(!IsPalindrome(substr)) { continue; }

                        if (count < substr.Length) {
                            output = substr;
                            count = substr.Length;
                        }
                    }
                }
                else { }
            }
        }

        

        return output;
    }


    public static string Operation4(string str)
    {
        if (str.Length == 0) { return string.Empty; }

        string output = string.Empty;
        int count = int.MinValue;

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            for (int j = i+1; j < str.Length; j++) {

                int length = j - i + 1;

                ch ^= str[j];

                int mid = (length / 2);

                if (str[mid] == ch)
                {
                    if ( length > count)
                    {
                        count = length;
                        output = str.Substring(i, length);
                    }
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
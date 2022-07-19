/* BITWISE OPERATOR PROPERTIES */
public static class BitwiseOperatorProperties
{

    // number & 1 i.e., number
    public static bool isEvenOdd(int n)
    {
        if ((n&1) == 1) { 
            return false;
        }

        return true;
    }


    //My observation to check whether string is palindrome or not based on XOR
    public static bool isPalindrome(string s)
    {
        char ch = s[0];

        for (int i = 1; i < s.Length; i++) {
            ch ^= s[i];
        }

        int mid = (s.Length / 2);

        Console.WriteLine(ch);
        if (s[mid] == ch) { 
            return true; 
        }

        return false;
    }
}
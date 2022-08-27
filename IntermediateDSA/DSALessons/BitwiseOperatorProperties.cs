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

    //Check if ith bit is set or not for N
    public static bool isBitSet(int n,int i)
    {
        if ((n & (1<<i)) !=0)
        {
            return true;
        }

        return false;
    }


    //Set the ith bit
    public static int setBit(int n, int i)
    {
        n = n | (1<<i);

        return n;
    }

    //Unset the ith bit
    public static int unsetBit(int n, int i)
    {
        n = n & (~(1 << i));

        return n;
    }

    //Toggle the ith bit
    public static int togggleBit(int n, int i)
    {
        n = n ^ (1 << i);

        return n;
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
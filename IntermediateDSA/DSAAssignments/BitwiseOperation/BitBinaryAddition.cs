/* Given two binary strings, return their sum (also a binary string).
Example:

a = "100"

b = "11"
Return a + b = "111".*/
public static class BitBinaryAddition
{
    public static string Operation1(string A, string B)
    {
        int N = 100000, carry = 0, i, j; string a = A, b = B;
        char[] outchars = new char[N];

        int diff = A.Length - B.Length;

        if (diff >= 0) {
            b = b.PadLeft(diff + b.Length, '0');
        }
        else {
            a = a.PadLeft(Convert.ToInt32(Math.Abs(diff)) + a.Length, '0');
        }

        j = a.Length;
        for (i = a.Length - 1; i >= 0; i--, j--) {

            int x = a[i] == '0' ? 0 : 1;
            int y = b[i] == '0' ? 0 : 1;

            int res = x + y + carry;

            carry = res / 2;

            outchars[j] = res % 2 == 0 ? '0' : '1';
        }

        if (carry != 0) {
            outchars[j] = carry == 1 ? '1' : '0';
        }

        return (((new string(outchars)).TrimStart('0')).Trim('\0'));
    }
}
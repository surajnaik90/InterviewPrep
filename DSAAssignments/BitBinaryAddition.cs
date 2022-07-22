/* Given two binary strings, return their sum (also a binary string).
Example:

a = "100"

b = "11"
Return a + b = "111".*/
public static class BitBinaryAddition
{
    public static string Operation1(string A, string B)
    {
        int N=32, carry=0, i;
        char[] outchars = new char[N];

        string a = string.Concat(new string(Enumerable.Repeat('0', N - A.Length).ToArray()),A);
        string b = string.Concat(new string(Enumerable.Repeat('0', N - B.Length).ToArray()), B);

        for (i = N-1; i >= 0; i--) {

            int res = a[i] + b[i] + carry;

            carry = res / 2;

            outchars[i] = res % 2 == 0 ? '0' : '1';
        }

        if(carry != 0) {
            outchars[i] = carry == 1 ? '1' : '0';
        }

        return (new string(outchars)).TrimStart('0');
    }
}
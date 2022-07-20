/* Given two binary strings, return their sum (also a binary string).
Example:

a = "100"

b = "11"
Return a + b = "111".*/
public static class BitBinaryAddition
{
    public static string Operation1(string A, string B)
    {
        string output = string.Empty;
        int N, carry=0; 

        if (A.Length < B.Length) { 
            N = B.Length;

            int[] newA = new int[N];

        }

        else if(B.Length < A.Length){ 
            N = A.Length;
            int[] newB = new int[N];
        }

        else { N = A.Length; }

        for (int i = N-1; i >= 0; i--) {

            int res = A[i] ^ B[i] ^ carry;

            carry = ((A[i] & B[i]) == '1') ? 1 : 0;

            output+=res.ToString();
        }

        if(carry != 0) {
            output += carry.ToString();
        }

        string result = string.Empty;
        for (int i = output.Length-1; i >=0 ; i--) {
            result += output[i];
        }

        return result;
    }
}
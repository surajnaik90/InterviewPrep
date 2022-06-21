/*
Given a string A, A is made up of 0's and 1's. Break A into substrings such that , 
all broken substrings have equal number of 1's and 0's.

Find and return maximum number of substrings in which A can be broken.
*/
public static class Teams
{
    public static int Operation1(string A)
    {
        if(string.IsNullOrEmpty(A)) {  return 0; }

        int output = 0, count = 0, expectedCount = 0, read = 0;
        bool split = false;
        char[] chars = A.ToCharArray();

        char ch = chars[0];
        for (int i = 0; i < chars.Length; i++)
        {
            if(chars[i] == ch) { count++; continue; }

            read++;
            if(read == 2) { split = true; read = 0; }
            
            if(!split)
            {
                ch = chars[i]; expectedCount = count; count = 1;

                if(expectedCount == count) { output++; count = 0; read = 0;}
            }
            else
            {
                if (expectedCount == count) { output++;  read = 0; }

                int res = i % expectedCount;

                i = i + (expectedCount - res ) - 1; count = 0;

                if(i+1 < chars.Length) { ch = chars[i+1]; split = false; }
            }
        }

        if (expectedCount == count) { output++; }

        if (output == 0) { output = 1; }

        return output;
    }

    private static string Helper(string str)
    {
        string res = string.Empty;

        char[] chars = str.ToCharArray();

        return res;
    }
}
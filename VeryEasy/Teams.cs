/*
Given a string A, A is made up of 0's and 1's. Break A into substrings such that , 
all broken substrings have equal number of 1's and 0's.

Find and return maximum number of substrings in which A can be broken.
*/
public static class Teams
{

    static int output = 1;
    //Operation 1 is super complicated approach. Go to solve
    public static int Operation1(string A)
    {
        if(string.IsNullOrEmpty(A)) {  return 0; }

        int output = 0, count = 0, expectedCount = 0, read = 0;
        bool split = false;
        char[] chars = A.ToCharArray();

        char ch = chars[0];
        for (int i = 0; i < chars.Length; i++)
        {
            if(chars[i] == ch) {

                if ( (expectedCount!=0) && (expectedCount == count))
                {
                    output++; count = 0; read = 0; expectedCount = 0;

                    if (i + 1 < chars.Length) { ch = chars[i + 1]; }
                    continue;
                }

                count++; 
                continue;
            }

            read++;
            if(read == 2) { split = true; read = 0; }
            
            if(!split)
            {
                ch = chars[i]; expectedCount = count; count = 1;

                if(expectedCount == count) { 
                    output++; count = 0; read = 0; expectedCount = 0;

                    if (i + 1 < chars.Length) { ch = chars[i + 1]; }
                }
            }
            else
            {
                if (expectedCount == count) { 
                    output++;  read = 0; expectedCount = 0;

                    if (i + 1 < chars.Length) { ch = chars[i + 1]; }
                }

                int res = i % expectedCount;

                i = i + (expectedCount - res ) - 1; count = 0;

                if(i+1 < chars.Length) { ch = chars[i+1]; split = false; }
            }
        }

        if (expectedCount == count) { output++; }

        if (output == 0) { output = 1; }

        return output;
    }


    public static int solve1(string A)
    {
        if(string.IsNullOrEmpty(A)) { return 0; }

        int count = 0; bool match = true;
        char ch = A[0];

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == ch) { count++; continue; }

            ch = A[i];
            for (int j = count; j < count*2; j++) {

                if (A[j] != ch) { match = false; break; }
            }

            if(match) {
                output++;
                string newStr = A.Remove(0, count*2);

                solve(newStr);
                break;
            }
            else { i = (count * 2)-1; }
        }

        return output;
    }

    public static int solve(string A)
    {
        if (string.IsNullOrEmpty(A)) { return 0; }

        List<char> zeros = new List<char>();
        List<char> ones = new List<char>();
        int output = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == '0') { zeros.Add(A[i]); }

            else { ones.Add(A[i]); }

            if (zeros.Count == ones.Count) { output++; }
        }

        return output;
    }
}
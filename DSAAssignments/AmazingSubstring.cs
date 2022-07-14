/*
You are given a string S, and you have to find all the amazing substrings of S.

An amazing Substring is one that starts with a vowel (a, e, i, o, u, A, E, I, O, U).

Input

Only argument given is string S.
Output

Return a single integer X mod 10003, here X is the number of Amazing Substrings in given the string.
Constraints

1 <= length(S) <= 1e6
S can have special characters
Example

Input
    ABEC

Output
    6

Explanation
    Amazing substrings of given string are :
    1. A
    2. AB
    3. ABE
    4. ABEC
    5. E
    6. EC
    here number of substrings are 6 and 6 % 10003 = 6.
See Expected Output
 */

public static class AmazingSubstring
{   

    //Time Limit Exceeded - Not optimized & fails too as it doesn't give the right answer.
    public static int Operation1(string A)
    {
        int output = 0; char[] vowels = new char[] {'a','e','i','o','u','A','E','I','O','U'};

        int length = A.Length;
        for (int i = 0; i < length; i++)
        {
            string str = string.Empty;
            for (int j = i; j < length; j++)
            {
                str = string.Concat(str, A[j]);
                if (vowels.Contains(str[0]))
                {
                    output++;
                }
            }
        }

        return output%10003;
    }

    public static int Operation2(string A)
    {
        if(A==string.Empty) { return 0; }

        A = A.ToLower();
        
        int length = A.Length, output=0, count=0;
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        Dictionary<char, int> vowelState = new Dictionary<char, int>() 
        { {'a',0 }, {'e',0 }, { 'i', 0 }, { 'o', 0 }, {'u',0 } };        

        char prev = A[0];
        for (int i = 0; i < length; i++)
        {
            if (!vowels.Contains(A[i])){ continue; }

            output += length - i;

            if (A[i] == prev) {
                count++;
                prev = A[i]; continue;
            }

            if(count <= vowelState[A[i]])
            {
                output = output - count;
            }
            else
            {
                output = output -(count - vowelState[A[i]]);
                vowelState[A[i]] = count;
            }

            int diff = ((count - 1) * (count)) / 2;
            output = output - diff;
            count = 0;
        }
        return output % 10003;
    }
}
/*
 * Raman is very fond of vowels.
 * One day, he got a string as a gift for his birthday.
 * He got very excited and wanted to obtain the longest subsequence of vowels from the original string. 
 * You are asked to help Raman.

Given a string A of lowercase English alphabets, find and return a string which is the longest subsequence of vowels
in the string A.

Note:

1. Vowels are 'a' , 'e' ,'i' , 'o' , 'u'. 
2. A subsequence is a sequence that can be derived from another sequence by deleting some or
no elements from the original sequence without changing the order of the remaining elements.
3. It is guaranteed that atleast one vowel will be present in the given string

Input 1:
   abcdye
Output 1:
    ae

Input 2:
    abhishek
Output 2:
    aie

Input 3:
    interviewbit
Output 3:
    ieiei
 */

public static class VowelIt
{
    public static string solve(string A)
    {
        if(string.IsNullOrEmpty(A)) { return string.Empty; }

        string output = string.Empty;
        char[] vowels = new char[] {'a','e','i','o','u'};

        for (int i = 0; i < A.Length; i++)
        {
            if (vowels.Contains(A[i])) {
                output = string.Concat(output, A[i]);
            }
        }

        return output;
    }
}
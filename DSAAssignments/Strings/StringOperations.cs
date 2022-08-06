/*
Akash likes playing with strings. One day he thought of applying following operations on the string in the given order:

Concatenate the string with itself.
Delete all the uppercase letters.
Replace each vowel with '#'.
You are given a string A of size N consisting of lowercase and uppercase alphabets. 
Return the resultant string after applying the above operations.

NOTE: 'a' , 'e' , 'i' , 'o' , 'u' are defined as vowels.

Problem Constraints

1<=N<=100000

Input Format

First argument is a string A of size N.

Output Format

Return the resultant string.

Example Input

A="AbcaZeoB"

Example Output

"bc###bc###"

Example Explanation

First concatenate the string with itself so string A becomes "AbcaZeoBAbcaZeoB".
Delete all the uppercase letters so string A becomes "bcaeobcaeo".
Now replace vowel with '#'.
A becomes "bc###bc###".
 */
using System.Text;

public static class StringOperations
{
    public static string solve(string A)
    {
        string res = string.Empty, s=string.Empty;
        char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append(A);
        stringBuilder.Append(A);

        char[] resultStrChars = stringBuilder.ToString().ToCharArray();

        for (int i = 0; i < resultStrChars.Length; i++) {

            if (resultStrChars[i]>='A' && resultStrChars[i] <= 'Z') {
                resultStrChars
            }
        }

        return res;
    }
}
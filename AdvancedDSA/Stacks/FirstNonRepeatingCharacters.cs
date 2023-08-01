/*
Given a string A denoting a stream of lowercase alphabets, you have to make a new string B.
B is formed such that we have to find the first non-repeating character each time a character is inserted 
to the stream and append it at the end to B. If no non-repeating character is found, append '#' at the end of B.

Problem Constraints
1 <= |A| <= 100000

Input Format
The only argument given is string A.

Output Format
Return a string B after processing the stream of lowercase alphabets A.

Example Input
Input 1:

 A = "abadbc"
Input 2:

 A = "abcabc"

Example Output
Output 1:

"aabbdd"
Output 2:

"aaabc#"

Example Explanation
Explanation 1:

"a"      -   first non repeating character 'a'
"ab"     -   first non repeating character 'a'
"aba"    -   first non repeating character 'b'
"abad"   -   first non repeating character 'b'
"abadb"  -   first non repeating character 'd'
"abadbc" -   first non repeating character 'd'
Explanation 2:

"a"      -   first non repeating character 'a'
"ab"     -   first non repeating character 'a'
"abc"    -   first non repeating character 'a'
"abca"   -   first non repeating character 'b'
"abcab"  -   first non repeating character 'c'
"abcabc" -   no non repeating character so '#'
 */

using System.Text;

public static class FirstNonRepeatingCharacters
{
    public static string solve(string A)
    {
        Queue<char> queue = new Queue<char>();
        Queue<char> output = new Queue<char>();




        queue.Enqueue(A[0]);
        output.Enqueue(A[0]);

        for (int i = 1; i < A.Length; i++) {

            char c = A[i];

            if (i == 47) {
                Console.WriteLine();
            }


            if(queue.Count == 0) {
                queue.Enqueue(A[i]);
                output.Enqueue(A[i]);
            }

            if (queue.Peek() != A[i]) {
                queue.Enqueue(A[i]);
                output.Enqueue(queue.Peek());
            }
            else {
                queue.Dequeue();

                if (queue.Count == 0) {
                    output.Enqueue('#');
                }
                else {
                    output.Enqueue(queue.Peek());
                }
            }
        }

        StringBuilder str = new StringBuilder();
        for (int i = A.Length-1; i >= 0; i--) {
            str.Append(output.Dequeue());
        }

        string res = str.ToString();

        return res;
    }
}
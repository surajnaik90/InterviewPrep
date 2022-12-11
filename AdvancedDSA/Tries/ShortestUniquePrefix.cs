/*
Given a list of N words, find the shortest unique prefix to represent each word in the list.

NOTE: Assume that no word is the prefix of another. In other words, the representation is always possible

Problem Constraints
1 <= Sum of length of all words <= 106

Input Format
First and only argument is a string array of size N.

Output Format
Return a string array B where B[i] denotes the shortest unique prefix to represent the ith word.

Example Input
Input 1:

 A = ["zebra", "dog", "duck", "dove"]
Input 2:

A = ["apple", "ball", "cat"]

Example Output
Output 1:

 ["z", "dog", "du", "dov"]
Output 2:

 ["a", "b", "c"]

Example Explanation
Explanation 1:

 Shortest unique prefix of each word is:
 For word "zebra", we can only use "z" as "z" is not any prefix of any other word given.
 For word "dog", we have to use "dog" as "d" and "do" are prefixes of "dov".
 For word "du", we have to use "du" as "d" is prefix of "dov" and "dog".
 For word "dov", we have to use "dov" as "d" and do" are prefixes of "dog".  
 
Explanation 2:

 "a", "b" and c" are not prefixes of any other word. So, we can use of first letter of each to represent.
 */

using System.Collections;
using System.Text;

public static class ShortestUniquePrefix
{
    private class TrieNode
    {
        public char data;
        public Dictionary<char, TrieNode> children;
        public int count;
        public bool isEnd;

        public TrieNode()
        {
            this.children = new Dictionary<char, TrieNode>();
            this.isEnd = false;
            this.count = 0;
        }
    }
    public static List<string> solve(List<string> A)
    {
        List<string> result = new List<string>();
        TrieNode root = new TrieNode();
        root.data = '*';

        foreach (string str in A) {

            TrieNode tmp = root;

            for (int i = 0; i < str.Length; i++) {

                if (!tmp.children.ContainsKey(str[i])) {
                    tmp.children.Add(str[i], new TrieNode());
                }

                tmp.count++;
                tmp = tmp.children[str[i]];
            }

            tmp.isEnd = true;
        }

        foreach (string str in A) {

            TrieNode tmp = root;
            StringBuilder strBuilder = new StringBuilder();

            for(int i = 0; i < str.Length; i++) {

                if(tmp.count == 1) {
                    break;
                }

                strBuilder.Append(str[i]);

                tmp = tmp.children[str[i]];
            }

            result.Add(strBuilder.ToString());
        }

        return result;
    }
}
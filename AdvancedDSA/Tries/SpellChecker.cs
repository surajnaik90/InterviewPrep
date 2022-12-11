﻿/*
Given an array of words A (dictionary) and another array B (which contain some words).

You have to return the binary array (of length |B|) as the answer where 1 denotes that the word 
is present in the dictionary and 0 denotes it is not present.

Formally, for each word in B, you need to return 1 if it is present in Dictionary and 0 if not.

Such problems can be seen in real life when we work on any online editor (like Google Documnet), 
if the word is not valid it is underlined by a red line.

NOTE: Try to do this in O(n) time complexity.

Problem Constraints
1 <= |A| <= 1000

1 <= sum of all strings in A <= 50000

1 <= |B| <= 1000

Input Format
First argument is array of strings A.

First argument is array of strings B.

Output Format
Return the binary array of integers according to the given format.

Example Input
Input 1:

A = [ "hat", "cat", "rat" ]
B = [ "cat", "ball" ]
Input 2:

A = [ "tape", "bcci" ]
B = [ "table", "cci" ]

Example Output
Output 1:

[1, 0]
Output 2:

[0, 0]

Example Explanation
Explanation 1:

Only "cat" is present in the dictionary.
Explanation 2:

None of the words are present in the dictionary.
 */

using System.Collections;


public static class SpellChecker
{
    private class TrieNode
    {
        public char data;
        public Dictionary<char, TrieNode> children;
        public bool isEnd;

        public TrieNode()
        {
            this.children = new Dictionary<char, TrieNode>();
            this.isEnd = false;
        }
    }
    public static List<int> solve(List<string> A, List<string> B)
    {
        List<int> result = new List<int>();
        TrieNode root = new TrieNode();
        root.data = '*';

        //Insert all the words present in A in Trie
        foreach (string str in A) {

            TrieNode tmp = root;

            for (int i = 0; i < str.Length; i++) {

                if (!tmp.children.ContainsKey(str[i])) {
                    tmp.children.Add(str[i], new TrieNode());
                }

                tmp = tmp.children[str[i]];
            }

            tmp.isEnd = true;
        }

        foreach (string str in B) {

            TrieNode tmp = root;

            for (int i = 0; i < str.Length; i++) {

                if (!tmp.children.ContainsKey(str[i])) {
                    break;
                }

                tmp = tmp.children[str[i]];
            }

            if(tmp.isEnd == true) {
                result.Add(1);
            }
            else {
                result.Add(0);
            }
        }

        return result;
    }
}
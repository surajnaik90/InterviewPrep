/*
We want to make a custom contacts finder applications as part of our college project. 
The application must perform two types of operations:

Type 1: Add name B[i] ,denoted by 0 in vector A where B[i] is a string in vector B denoting a contact name. 
This must store B[i] as a new contact in the application.

Type 2: Find partial for B[i] ,denoted by 1 in vector A where B[i] is a string in vector B denoting a partial name to
search the application for. It must count the number of contacts starting with B[i].

You have been given sequential add and find operations. You need to perform each operation in order.

And return as an array of integers, answers for each query of type 2(denoted by 1 in A).

Problem Constraints

1 <= |A| <= 10000

1 <= |length of strings in B| <= 10

Input Format

First argument is the vector A, which denotes the type of query.

Second argument is the vector B, which denotes the string for corresponding query.

Output Format

Return an array of integers, denoting answers for each query of type 1.

Example Input

Input 1:

A = [0, 0, 1, 1]
B = ["hack", "hacker", "hac", "hak"]
Input 2:

A = [0, 1]
B = ["abcde", "abc"]

Example Output

Output 1:
 
[2, 0]
Output 2:

[1]

Example Explanation

Explanation 1:
 
We perform the following sequence of operations:
Add a contact named "hack".
Add a contact named "hacker".
Find the number of contact names beginning with "hac". 
There are currently two contact names in the application and both of them start with "hac", so we have 2.
Find the number of contact names beginning with "hak". 
There are currently two contact names in the application but neither of them start with "hak", so we get0.
Explanation 2:

 
Add "abcde"
Find words with prefix "abc". We have answer as 1.

 */

using System.Collections;
using System.Text;

public static class ContactFinder
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
    public static List<int> solve(List<int> A, List<string> B)
    {
        List<int> result = new List<int>();
        TrieNode root = new TrieNode();
        root.data = '*';

        for (int i = 0; i < A.Count; i++) {

            switch (A[i]) {
                case 0:
                    TrieNode tmp = root;
                    for (int j = 0; j < B[i].Length; j++) {

                        if (!tmp.children.ContainsKey(B[i][j])) {
                            tmp.children.Add(B[i][j], new TrieNode());
                        }

                        tmp = tmp.children[B[i][j]];
                        tmp.count++;
                    }
                    break;
                case 1:
                    TrieNode temp = root;
                    for (int j = 0; j < B[i].Length; j++) {

                        if (!temp.children.ContainsKey(B[i][j])) {
                            break;
                        }
                        temp = temp.children[B[i][j]];
                    }
                    result.Add(temp.count); 
                    break;
            }
        }

        return result;
    }
}
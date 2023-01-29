/*
You are given N towns (1 to N). All towns are connected via unique directed path as 
mentioned in the input.

Given 2 towns find whether you can reach the first town from the second without 
repeating any edge.

B C : query to find whether B is reachable from C.

Input contains an integer array A of size N and 2 integers B and C ( 1 <= B, C <= N ).

There exist a directed edge from A[i] to i+1 for every 1 <= i < N. Also, it's guaranteed
that A[i] <= i for every 1 <= i < N.

NOTE: Array A is 0-indexed. A[0] = 1 which you can ignore as it doesn't represent any edge.

Problem Constraints
1 <= N <= 100000

Input Format
First argument is vector A

Second argument is integer B

Third argument is integer C

Output Format
Return 1 if reachable, 0 otherwise.

Example Input
Input 1:

 A = [1, 1, 2]
 B = 1
 C = 2
Input 2:

 A = [1, 1, 2]
 B = 2
 C = 1

Example Output
Output 1:

 0
Output 2:

 1

Example Explanation
Explanation 1:

 Tree is 1--> 2--> 3 and hence 1 is not reachable from 2.
Explanation 2:

 Tree is 1--> 2--> 3 and hence 2 is reachable from 1.
 */

using System.Collections;
using System.Net.Http.Headers;
using System.Xml.Linq;

public static class DepthFirstSearch
{
    public static int solve(List<int> A, int B, int C)
    {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

        for (int i = 1; i < A.Count; i++) {

            int key = A[i];

            if (map.ContainsKey(key)) {
                map[key].Add(i + 1);
            }
            else {
                map.Add(key, new List<int>() { i + 1 });
            }
        }

        int ans = dfs(map, C, B);

        return ans;
    }

    public static int dfs(Dictionary<int, List<int>> map, int curr, int dest)
    {
        if (curr == dest) {
            return 1;
        }

        if(!map.ContainsKey(curr)) {

            return 0;
        }

        int ans = 0;

        for (int i = 0; i < map[curr].Count; i++) {

            int element = map[curr].ElementAt(i);

            ans = dfs(map, element, dest);

            if (ans == 1) { break; }
        }

        return ans;
    }
}
/*
Given an one-dimensional integer array A of size N and an integer B.

Count all distinct pairs with difference equal to B.

Here a pair is defined as an integer pair (x, y), 
where x and y are both numbers in the array and their absolute difference is B.

Problem Constraints
1 <= N <= 104

0 <= A[i], B <= 105

Input Format
First argument is an one-dimensional integer array A of size N.

Second argument is an integer B.

Output Format
Return an integer denoting the count of all distinct pairs with difference equal to B.

Example Input
Input 1:

 A = [1, 5, 3, 4, 2]
 B = 3
Input 2:

 A = [8, 12, 16, 4, 0, 20]
 B = 4
Input 3:

 A = [1, 1, 1, 2, 2]
 B = 0


Example Output
Output 1:

 2
Output 2:

 5
Output 3:

 2


Example Explanation
Explanation 1:

 There are 2 unique pairs with difference 3, the pairs are {1, 4} and {5, 2} 
Explanation 2:

 There are 5 unique pairs with difference 4, the pairs are {0, 4}, {4, 8}, {8, 12}, {12, 16} and {16, 20} 
Explanation 3:

 There are 2 unique pairs with difference 0, the pairs are {1, 1} and {2, 2}.
 */

public static class PairsGivenDifference
{
    //Doesn't work
    public static int solve1(List<int> A, int B)
    {   
        A.Sort();

        int ans = 0, N = A.Count;
        Dictionary<int, int> hashMap = new Dictionary<int, int>();        

        for (int i = 0; i < N; i++) {

            if (hashMap.ContainsKey(A[i])) {
                hashMap[A[i]]++;    
            }
            else {
                hashMap[A[i]] = 1;
            }
        }

        if (hashMap.Count == 1) { 
        
            int val = hashMap[A[0]];

            if (val > 1) { return 1; }
        }

        int left = 0, right = hashMap.Count-1, diff = 0;

        while (left < hashMap.Count) {

            if (right < left) {
                right += 2;
            }

            diff = Math.Abs(hashMap.Keys.ElementAt(left) - hashMap.Keys.ElementAt(right));

            if (diff < B) {
                left++;
            }
            else if(diff > B) {
                right--;
            }
            else {

                if (left != right) {
                    ans += 1;
                }
                left++; right++;

                if(right >= hashMap.Count) {
                    break;
                }
            }
        }
        return ans;
    }

    //Doesn't work
    public static int solve2(List<int> A, int B)
    {
        A.Sort();

        int output = 0;
        int start = 0, end = A.Count - 1;

        while (start < A.Count)
        {
            if (start > end) {
                end = A.Count - 1;
            }

            int diff = Math.Abs(A[start] - A[end]);

            if (diff > B) {
                end--;
            }
            else if (diff < B) {
                start++;
            }
            else {

                if (start != end) { 
                    output++; 
                }

                int i = start; start++;

                while (start < A.Count) {
                    
                    if (A[i] != A[start]) {
                        break;
                    }

                    start++;
                }
                end = A.Count - 1;

            }
        }

        return output;
    }

    public static int solve3(List<int> A, int B)
    {
        Console.WriteLine("B = " + B);
        int output = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < A.Count; i++) {

            if (map.ContainsKey(A[i])) {
                map[A[i]]++;
            }
            else {
                map[A[i]] = 1;
            }
        }

        for (int i = 0; i < A.Count; i++) {

            int val = A[i];            

            int possiblePair1Val = A[i] - B;
            int possiblePair2Val = A[i] + B;

            if (map.ContainsKey(A[i])) {

                if (A[i] == possiblePair1Val || A[i] == possiblePair2Val) {

                    if (map[A[i]] > 1) {
                        output += 1;
                        Console.WriteLine("Pair formed is: {" + val + ", " + val + "}");
                    }
                }
                map.Remove(A[i]);

                if (possiblePair1Val >= 0)
                {
                    if (map.ContainsKey(possiblePair1Val))
                    {
                        output += 1;
                        Console.WriteLine("Pair formed is: {" + val + ", " + possiblePair1Val + "}");
                    }
                }

                if (possiblePair2Val >= 0)
                {
                    if (map.ContainsKey(possiblePair2Val))
                    {
                        output += 1;
                        Console.WriteLine("Pair formed is: {" + val + ", " + possiblePair2Val + "}");
                    }
                }
            }

            
        }

        Console.WriteLine("Total Distinct Pairs Count: " + output);

        return output;
    }
}
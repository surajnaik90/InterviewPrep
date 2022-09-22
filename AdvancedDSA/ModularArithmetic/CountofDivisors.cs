/*
Given an array of integers A, find and return the count of divisors of each element of the array.

NOTE: The order of the resultant array should be the same as the input array.

Problem Constraints
1 <= length of the array <= 100000
1 <= A[i] <= 106

Input Format
The only argument given is the integer array A.

Output Format
Return the count of divisors of each element of the array in the form of an array.

Example Input
Input 1:

 A = [2, 3, 4, 5]
Input 2:

 A = [8, 9, 10]


Example Output
Output 1:

 [2, 2, 3, 2]
Output 1:

 [4, 3, 4]


Example Explanation
Explanation 1:

 The number of divisors of 2 : [1, 2], 3 : [1, 3], 4 : [1, 2, 4], 5 : [1, 5]
 So the count will be [2, 2, 3, 2].
Explanation 2:

 The number of divisors of 8 : [1, 2, 4, 8], 9 : [1, 3, 9], 10 : [1, 2, 5, 10]
 So the count will be [4, 3, 4].
 */

public static class CountofDivisors
{
    // Time Limit Exceeds
    public static List<int> solve(List<int> A)
    {
        List<int> res = new List<int>();
        int N = A.Count;

        for (int i = 0; i < N; i++) {

            int count = 0, num = 1;

            while (num <= A[i]) {
                if (A[i] % num == 0) {
                    count++;
                }
                num++;
            }
            res.Add(count);
        }

        return res;
    }

    //Approach 2: Use HashMaps - Time Limit Exceeds
    public static List<int> optimallySolve1(List<int> A)
    {
        List<int> res = new List<int>();
        Dictionary<int, int> map = new Dictionary<int, int>();
        int N = A.Count;
         
        for (int i = 0; i < N; i++) {

            if (map.ContainsKey(A[i])) {
                res.Add(map[A[i]]);
            }
            else {
                map.Add(A[i], 0);
                int count = 0, num = 1;

                while (num <= A[i]) {
                    if (A[i] % num == 0) {
                        count++;
                    }
                    num++;
                }
                res.Add(count);
                map[A[i]] = count;
            }
        }

        return res;
    }


    //Approach 3: Optimal approach - Sieve's technique
    public static List<int> optimallySolve2(List<int> A)
    {
        List<int> result = new List<int>();

        int N = A.Count, max = int.MinValue;

        for (int i = 0; i < N; i++) {
            max = Math.Max(max, A[i]);
        }

        int[] count = new int[max + 1];
        for (int i = 1; i <= max; i++) {

            for (int j = i; j <= max; j += i) {
                count[j]++;
            }
        }

        for (int i = 0; i < N; i++) {
            result.Add(count[A[i]]);
        }

        return result;
    }
}
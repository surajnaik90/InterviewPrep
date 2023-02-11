/*
Given an integer array B of size N.

You need to find the Ath largest element in the subarray [1 to i], where i varies from 1 to N. 
In other words, find the Ath largest element in the sub-arrays [1 : 1], [1 : 2], [1 : 3], ...., [1 : N].

NOTE: If any subarray [1 : i] has less than A elements, then the output should be -1 at the ith index.

Problem Constraints
1 <= N <= 100000
1 <= A <= N
1 <= B[i] <= INT_MAX

Input Format
The first argument is an integer A.
The second argument is an integer array B of size N.

Output Format
Return an integer array C, where C[i] (1 <= i <= N) will have the Ath largest element in the subarray [1 : i].

Example Input
Input 1:

 A = 4  
 B = [1 2 3 4 5 6] 
Input 2:

 A = 2
 B = [15, 20, 99, 1]


Example Output
Output 1:

 [-1, -1, -1, 1, 2, 3]
Output 2:

 [-1, 15, 20, 20]


Example Explanation
Explanation 1:

 for i <= 3 output should be -1.
 for i = 4, Subarray [1:4] has 4 elements 1, 2, 3 and 4. So, 4th maximum element is 1.
 for i = 5, Subarray [1:5] has 5 elements 1, 2, 3, 4 and 5. So, 4th maximum element is 2.
 for i = 6, Subarray [1:6] has 6 elements 1, 2, 3, 4, 5 and 6. So, 4th maximum element is 3.
 So, output array is [-1, -1, -1, 1, 2, 3].
 
Explanation 2:

 for i <= 1 output should be -1.
 for i = 2 , Subarray [1:2] has 2 elements 15 and 20. So, 2th maximum element is 15.
 for i = 3 , Subarray [1:3] has 3 elements 15, 20 and 99. So, 2th maximum element is 20.
 for i = 4 , Subarray [1:4] has 4 elements 15, 20, 99 and 1. So, 2th maximum element is 20.
 So, output array is [-1, 15, 20, 20].
 */

public class AElement : IComparable<AElement>
{
    public int element;
    public int priority;

    public AElement(int val, int priority)
    {
        this.element = val;
        this.priority = priority;
    }

    public int CompareTo(AElement other)
    {
        if (this.priority < other.priority) return -1;
        else if (this.priority > other.priority) return 1;
        else return 0;
    }
}

public static class ALargestElement
{
    public static List<int> solve(int A, List<int> B)
    {
        List<int> res = new List<int>();
        PriorityQueue<AElement> q =
            new PriorityQueue<AElement>();

        for (int i = 0; i < B.Count; i++) {

            q.Enqueue(new AElement(B[i], B[i]));

            if(i < A - 1) {
                res.Add(-1);
                continue;
            }
            else {
                res.Add(q.Dequeue().element);
            }
        }

        return res;
    }

    public static List<int> solve2(int A, List<int> B)
    {
        List<int> res = new List<int>();

        PriorityQueue<int, int> q =
            new PriorityQueue<int, int>();

        for (int i = 0; i < B.Count; i++) {

            q.Enqueue(B[i], B[i]);

            if(i < A - 1) {
                res.Add(-1);
                continue;
            }

            res.Add(q.UnorderedItems.ElementAt(q.Count - A).Element);
        }

        return res;
    }
}
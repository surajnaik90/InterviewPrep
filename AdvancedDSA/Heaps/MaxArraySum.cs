/*
Given an array of integers A and an integer B. You must modify the array exactly B number of times. 
In a single modification, we can replace any one array element A[i] by -A[i].

You need to perform these modifications in such a way that after exactly B modifications,
sum of the array must be maximum.

Problem Constraints
1 <= length of the array <= 5*105
1 <= B <= 5 * 106
-100 <= A[i] <= 100

Input Format
The first argument given is an integer array A.
The second argument given is an integer B.

Output Format
Return an integer denoting the maximum array sum after B modifications.

Example Input
Input 1:

 A = [24, -68, -29, -9, 84]
 B = 4
Input 2:

 A = [57, 3, -14, -87, 42, 38, 31, -7, -28, -61]
 B = 10

Example Output
Output 1:

 196
Output 2:

 362

Example Explanation
Explanation 1:

 Final array after B modifications = [24, 68, 29, -9, 84]
Explanation 2:

 Final array after B modifications = [57, -3, 14, 87, 42, 38, 31, 7, 28, 61]
 */

public class Item : IComparable<Item>
{
    public int element;
    public int priority;

    public Item(int val, int priority)
    {
        this.element = val;
        this.priority = priority;
    }

    public int CompareTo(Item other)
    {
        if (this.priority < other.priority) return -1;
        else if (this.priority > other.priority) return 1;
        else return 0;
    }
}

public static class MaxArraySum
{
    public static int solve(List<int> A, int B)
    {
        long result = 0;
        PriorityQueue<Item> q = new PriorityQueue<Item>();

        for (int i = 0; i < A.Count; i++) {
            q.Enqueue(new Item(A[i], A[i]));

            result += A[i];
        }

        for (int i = 1; i <= B; i++) {

            int val = q.Dequeue().element;

            result -= val;

            q.Enqueue(new Item(-val, -val));

            result += -val;

        }

        return (int)result;
    }
}
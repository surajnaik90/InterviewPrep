/*
Given N bags, each bag contains Bi chocolates. There is a kid and a magician.
In a unit of time, the kid can choose any bag i, and eat Bi chocolates from it,
then the magician will fill the ith bag with floor(Bi/2) chocolates.

Find the maximum number of chocolates that the kid can eat in A units of time.

NOTE:

floor() function returns the largest integer less than or equal to a given number.
Return your answer modulo 109+7

Problem Constraints
1 <= N <= 100000
0 <= B[i] <= INT_MAX
0 <= A <= 105

Input Format
The first argument is an integer A.
The second argument is an integer array B of size N.

Output Format
Return an integer denoting the maximum number of chocolates the kid can eat in A units of time.

Example Input
Input 1:

 A = 3
 B = [6, 5]
Input 2:

 A = 5
 b = [2, 4, 6, 8, 10]


Example Output
Output 1:

 14
Output 2:

 33


Example Explanation
Explanation 1:

 At t = 1 kid eats 6 chocolates from bag 0, and the bag gets filled by 3 chocolates. 
 At t = 2 kid eats 5 chocolates from bag 1, and the bag gets filled by 2 chocolates. 
 At t = 3 kid eats 3 chocolates from bag 0, and the bag gets filled by 1 chocolate. 
 so, total number of chocolates eaten are 6 + 5 + 3 = 14
Explanation 2:

 Maximum number of chocolates that can be eaten is 33.
 */


//https://github.com/dotnet/runtime/blob/main/src/libraries/System.Collections/src/System/Collections/Generic/PriorityQueue.cs
//https://visualstudiomagazine.com/Articles/2012/11/01/Priority-Queues-with-C.aspx?Page=2

using System.Collections.Generic;
public class Bag : IComparable<Bag>
{
    public int element;
    public int priority;

    public Bag(int val, int priority)
    {
        this.element = val;
        this.priority = priority;
    }

    public int CompareTo(Bag other)
    {
        if (this.priority < other.priority) return 1;
        else if (this.priority > other.priority) return -1;
        else return 0;
    }
}
public static class MagicianChocolates
{
    public static int solve(int A, List<int> B)
    {
        long result = 0;
        PriorityQueue<Bag> q = new PriorityQueue<Bag>();

        for (int i = 0; i < B.Count; i++) {
            q.Enqueue(new Bag(B[i], B[i]));
        }

        for (int i = 1; i <= A; i++) {

            int val = q.Dequeue().element;

            result += val;

            result %= (int)(Math.Pow(10, 9) + 7);

            int newBagItem = Convert.ToInt32(Math.Floor( (decimal)val / 2));

            q.Enqueue(new Bag(newBagItem, newBagItem));
        }

        return (int)result;
    }
}
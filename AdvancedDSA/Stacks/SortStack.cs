/*
Given a stack of integers A, sort it using another stack.

Return the array of integers after sorting the stack using another stack.

Problem Constraints
1 <= |A| <= 5000

0 <= A[i] <= 109

Input Format
The only argument is a stack given as an integer array A.

Output Format
Return the array of integers after sorting the stack using another stack.

Example Input
Input 1:

 A = [5, 4, 3, 2, 1]
Input 2:

 A = [5, 17, 100, 11]

Example Output
Output 1:

 [1, 2, 3, 4, 5]
Output 2:

 [5, 11, 17, 100]


Example Explanation
Explanation 1:

 Just sort the given numbers.
Explanation 2:

 Just sort the given numbers.
 */

using System.Text;

public static class SortStack
{
    public static List<int> solve(List<int> A)
    {
        Stack<int> stackA = new Stack<int>();
        Stack<int> stackB = new Stack<int>();

        stackA.Push(A[0]);

        for (int i = 1; i < A.Count; i++) {

            int curr = A[i];

            if(stackA.Count==0) {
                stackA.Push(curr);
                continue;
            }

            if(curr > stackA.Peek()) {

                if (stackB.Count == 0) {
                    stackA.Push(curr);
                    continue;
                }

                if(curr < stackB.Peek()) {
                    stackA.Push(curr);
                }
                else {

                    while (curr > stackB.Peek()) {

                        stackA.Push(stackB.Pop());

                        if(stackB.Count == 0) { break; }
                    }

                    stackA.Push(curr);
                }
            }
            else {

                while(curr < stackA.Peek()) {

                    stackB.Push(stackA.Pop());

                    if (stackA.Count == 0) { break; }
                }

                stackA.Push(curr);
            }
        }

        while(stackB.Count > 0) {
            stackA.Push(stackB.Pop());

        }


        int[] result = new int[A.Count];

        for (int i = A.Count - 1; i >= 0 ; i--) {
            result[i] = stackA.Pop();
        }

        return result.ToList();
    }
}
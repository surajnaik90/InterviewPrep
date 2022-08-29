/*
 You are given a nested list of integers nestedList. Each element is either an integer or a list whose elements
may also be integers or other lists. Implement an iterator to flatten it.

Implement the NestedIterator class:

NestedIterator(List nestedList) Initializes the iterator with the nested list nestedList.
int next() Returns the next integer in the nested list.
boolean hasNext() Returns true if there are still some integers in the nested list and false otherwise.

Example 1:
Input: nestedList = [[1,1],2,[1,1]]
Output: [1,1,2,1,1]
Explanation: By calling next repeatedly until hasNext returns false, the order of elements returned by next should be: [1,1,2,1,1].
Example 2:
Input: nestedList = [1,[4,[6]]]
Output: [1,4,6]
Explanation: By calling next repeatedly until hasNext returns false, the order of elements returned by next should be: [1,4,6].
Constraints:
The sum of integers in all cases does not exceed 1e5.
The values of the integers in the nested list are in the range [-1e6, 1e6].
 */
public static class NestedIteratot
{
    public class NestedInteger
    {
        int val;

        NestedInteger next;

        public NestedInteger(int val, NestedInteger next)
        {
            this.val = val;
            this.next = next;   
        }
    }
    public class NestedIterator
    {
        List<NestedInteger> nestList;
        public NestedIterator(List<NestedInteger> nestedList)
        {
            this.nestList = nestedList;
        }

        public int next()
        {
            return 1;
        }

        public bool hasNext()
        {
            return false;
        }
    }
}
/* Given an array of positive integers A, two integers appear only once, and all the other integers appear twice.
Find the two integers that appear only once.

Note: Return the two numbers in ascending order.


Problem Constraints
2 <= |A| <= 100000
1 <= A[i] <= 109



Input Format
The first argument is an array of integers of size N.



Output Format
Return an array of two integers that appear only once.



Example Input
Input 1:
A = [1, 2, 3, 1, 2, 4]
Input 2:

A = [1, 2]


Example Output
Output 1:
[3, 4]
Output 2:

[1, 2]


Example Explanation
Explanation 1:
3 and 4 appear only once.
Explanation 2:

1 and 2 appear only once.*/
public static class SingleNumberIII
{
    public static List<int> Operation1(List<int> A)
    {
        //Take XOR of all elements
        int res = A[0];
        for (int i = 1; i < A.Count; i++)
        {
            res ^= A[i];
        }

        //Find the first set bit from right side
        int temp = res, bit = 0;
        while(temp!=0) {
            if( (temp & 1)==1) {
                break;
            }
            bit++;
            temp /= 2;
        }

        //Find the unique elements
        int element1=0, element2=0;
        for (int i = 0; i < A.Count; i++)
        {
            if (((A[i]&(1<<bit)) != 0)) {
                element1 ^= A[i];
            }

            else {
                element2 ^= A[i];
            }
        }

        int n = element1;
        if(element1 > element2)
        {
            element1 = element2;
            element2 = n;
        }

        return new List<int>() { element1, element2};
    }
}
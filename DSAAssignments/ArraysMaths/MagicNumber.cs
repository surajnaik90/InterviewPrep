/* Given an integer A, find and return the Ath magic number.

A magic number is defined as a number that can be expressed as a power of 5 or a sum of unique powers of 5.

First few magic numbers are 5, 25, 30(5 + 25), 125, 130(125 + 5), ….

Problem Constraints
1 <= A <= 5000

Input Format
The only argument given is integer A.

Output Format
Return the Ath magic number.

Example Input
Example Input 1:

 A = 3
Example Input 2:

 A = 10

Example Output
Example Output 1:

 30
Example Output 2:

 650

Example Explanation
Explanation 1:

 Magic Numbers in increasing order are [5, 25, 30, 125, 130, ...]
 3rd element in this is 30
Explanation 2:

 In the sequence shown in explanation 1, 10th element will be 650.
 */
public static class MagicNumber
{
    public static int solve(int A)
    {
        int power = Convert.ToInt32(Math.Floor(Math.Log2(A)));

        /*int power = 0;int number = A;
        while (number > 1) {
            number /= 2;
            power++;
        }*/

        int diff = Convert.ToInt32(A - Math.Pow(2, power));

        int sum = Convert.ToInt32(Math.Pow(5, power + 1));

        if (diff == 0) {
            return sum;
        }
        else {
            sum += solve(diff);
        }

        return sum;
    }
}
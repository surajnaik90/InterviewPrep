/*
The gray code is a binary numeral system where two successive values differ in only one bit.

Given a non-negative integer A representing the total number of bits in the code, print the sequence of gray code.

A gray code sequence must begin with 0.

Problem Constraints
1 <= A <= 16

Input Format
The first argument is an integer A.

Output Format
Return an array of integers representing the gray code sequence.

Example Input
Input 1:

A = 2
Input 1:

A = 1

Example Output
output 1:

[0, 1, 3, 2]
output 2:

[0, 1]

Example Explanation
Explanation 1:

for A = 2 the gray code sequence is:
    00 - 0
    01 - 1
    11 - 3
    10 - 2
So, return [0,1,3,2].
Explanation 1:

for A = 1 the gray code sequence is:
    00 - 0
    01 - 1
So, return [0, 1].
 */
public static class GrayCode
{
    public static List<int> solve(int A)
    {
        List<int> result = new List<int>();

        List<string> grayCodes = generateGrayCodes(A, new List<string>() { "0", "1" });

        for (int i = 0; i < grayCodes.Count; i++) { 

            int value=0;

            for (int j = grayCodes[i].Length-1,k=0; j >=0 ; j--,k++) {

                value += (Convert.ToInt32(Math.Pow(2, k))) * (Convert.ToInt32(char.GetNumericValue(grayCodes[i][j])));
            }

            result.Add(value);
        }

        return result;
    }

    private static List<string> generateGrayCodes(int A, List<string> codes)
    {
        int value = Convert.ToInt32(Math.Pow(2, A));
        
        if(codes.Count == value) {
            return codes;
        }

        List<string> grayCodes = new List<string>();

        for (int i = 0; i < codes.Count; i++) {
            string grayCode = "0" + codes[i];
            grayCodes.Add(grayCode);

        }

        for (int i = codes.Count-1; i >=0; i--) {
            string grayCode = "1" + codes[i];
            grayCodes.Add(grayCode);
        }

        return generateGrayCodes(A, grayCodes);
    }
}
/* In an array of N elements, find the majorty element.
 * 
 * Majority Element: An element whose frequency is largest and is greater than N/2
 * If found return 1 else return -1
 * 
 * Exxample:  4 4 3 8 8 4 9 4 4
 * 
 * Output: 4
 * 
 * 
 * This problem is called as Majority Element problem or Moore Voting Algorithm problem.
 */
public static class MooreVotingAlgorithm
{   
    public static int Operation1(List<int> A)
    {
        int frequency = 0, element = int.MinValue;
        for (int i = 0; i < A.Count; i++)
        {
            if(frequency==0) {
                element = A[i];
                frequency++;
            }
            else if (element == A[i]) {
                frequency++;
            }
            else {
                frequency -= 1;

                if (frequency == 0) {
                    element = int.MinValue;
                }
            }
        }

        int count = 0;
        for (int i = 0; i < A.Count; i++) {
            if (A[i] == element) {
                count++;
            }
        }

        int N = A.Count / 2;
        if(count> N/2) { 
            return element;
        }
        else {
            return -1;
        }
    }
}
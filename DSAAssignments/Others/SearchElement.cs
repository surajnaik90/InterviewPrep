/*
You are given an integer T (number of test cases). You are given array A and an integer B for each test case. You have to tell whether B is present in array A or not.



Problem Constraints
1 <= T <= 10

1 <= |A| <= 105

1 <= A[i], B <= 109



Input Format
First line of the input contains a single integer T.

Next, each of the test case consists of 2 lines:

First line begins with an integer |A| denoting the length of array, and then |A| integers denote the array elements.
Second line contains a single integer B


Output Format
For each test case, print on a separate line 1 if the element exists, else print 0.



Example Input
Input 1:

 1 
 5 4 1 5 9 1
 5
Input 2:

 1
 3 7 7 2
 1 


Example Output
Output 1:

 1 
Output 2:

 0 


Example Explanation
Explanation 1:

  B = 5  is present at position 3 in A 
Explanation 2:

  B = 1  is not present in A. 
 */

public static class SearchElement
{
    public static void Operation1()
    {
        int T = Convert.ToInt32(Console.ReadLine());
        List<int> searchElements = new List<int>();
        List<List<int>> arrinputs = new List<List<int>>();

        for (int i = 0; i < T; i++)
        {
            string userInput = Console.ReadLine();

            string[] inputs = userInput.Split();

            int N = Convert.ToInt32(inputs[0]);
            List<int> list = new List<int>();
            list.Add(N);

            for (int j = 1; j <= N; j++) {
                list.Add(Convert.ToInt32(inputs[j]));
            }

            arrinputs.Add(list);

            string s = Console.ReadLine();
            searchElements.Add(Convert.ToInt32(s));
        }

        bool found = false;
        for (int i = 0; i < T; i++)
        {
            found = false;
            for (int j = 1; j < arrinputs[i].Count; j++)
            {
                if(arrinputs[i][j] == searchElements[i]) 
                {
                    Console.WriteLine(1);
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                Console.WriteLine(0);
            }
        }
        
    }
}
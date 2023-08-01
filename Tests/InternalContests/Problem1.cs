

public static class Problem1
{
    public static int solve(int A, int B, int C)
    {
        int i = 1, start = int.MaxValue;
        int originalA = A;
        HashSet<int> primeNosInA = new HashSet<int>();

        
        while (i <= C)
        {
            A = A & (start << i++);
        }

        int j = 0, newNum = 0;
        while (j < B)
        {
            newNum = newNum | (originalA & (1 << j++));
        }

        return A ^ newNum;
    }

    public static List<int> solve2(List<int> A, List<List<int>> B)
    {

        List<int> result = new List<int>();

        //Find the maximum nuumber
        int maxNumber = int.MinValue;
        for (int i = 0; i < A.Count; i++)
        {
            maxNumber = Math.Max(maxNumber, A[i]);
        }

        //Find the prime numbers till that maxNumbers
        HashSet<int> primeNosInA = new HashSet<int>();
        bool[] sieveArray = new bool[maxNumber + 1];

        for (int i = 2; i <= maxNumber; i++)
        {

            for (int j = 2 * i; j <= maxNumber; j = j + i)
            {
                sieveArray[j] = true;
            }

        }

        //Fill the primeNumbers hashset
        for (int i = 1; i <= sieveArray.Length; i++)
        {

            if (sieveArray[i] == false)
            {
                primeNosInA.Add(i);
            }
        }


        //Compute the result
        for (int i = 0; i < B.Count; i++)
        {

            int startIndex = B[i][0] - 1, endIndex = B[i][1] - 1;
            int primeNosCount = 0;

            for (int j = startIndex; j <= endIndex; j++)
            {

                if (primeNosInA.Contains(A[j]))
                {
                    primeNosCount++;
                }
            }

            result.Add(primeNosCount);
        }

        return result;
    }

    public static string solve3(List<string> A, List<string> B)
    {

        Dictionary<string, int> map = new Dictionary<string, int>();

        for (int i = 0; i < A.Count; i++)
        {
            if (map.ContainsKey(A[i]) && !B.Contains(A[i]))
            {
                map[A[i]]++;
            }
            else if (!B.Contains(A[i]))
            {
                map[A[i]] = 1;
            }
        }

        string output = string.Empty;
        List<string> temp = new List<string>();
        List<int> tempInts = new List<int>();
        int repCount = int.MinValue;
        //Find the min
        for (int i = 0; i < map.Count; i++)
        {
            temp.Add(map.ElementAt(i).Key);
            tempInts.Add(map.ElementAt(i).Value);
            //repCount = Math.Max(repCount, map.ElementAt(i).Value);
        }

        temp.Sort();
        tempInts.Sort();

        repCount = tempInts[tempInts.Count - 1];


        for (int i = 0; i < temp.Count; i++)
        {

            if (map[temp[i]] == repCount)
            {
                output = temp[i];
            }

        }

        return output;
    }
}
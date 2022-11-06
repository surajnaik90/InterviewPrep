//Rabin Karp Algorithm

public static class RabinKarp
{
    //Using Rolling Hash technique
    public static int solve(string A)
    {
        int count = 0; long mod = ((long)(Math.Pow(10, 9) + 7));
        long hash = 0, reverseHash = 0; int N = A.Length;


        int j = N - 1;
        for (int i = 0; i < N; i++)
        {

            hash += (((long)(Math.Pow(26, j--))) * A[i]);
            hash %= mod;

            reverseHash += (((long)(Math.Pow(26, i))) * A[i]);
            reverseHash %= mod;
        }

        if (hash == reverseHash)
        {
            return 0;
        }

        long newHash = hash, newReverseHash = reverseHash; j = N;
        for (int i = 1; i < N; i++)
        {

            newHash = hash + ((((long)(Math.Pow(26, j++))) * (long)A[i]));
            newHash %= mod;
            hash = newHash;

            newReverseHash = ((long)(26 * reverseHash)) + ((long)A[i]);
            newReverseHash %= mod;
            reverseHash = newReverseHash;

            if (newHash == newReverseHash)
            {
                return count;
            }
            count++;
        }

        return count;
    }
}
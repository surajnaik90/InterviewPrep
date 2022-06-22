public static class VowelIt
{
    public static string solve(string A)
    {
        if(string.IsNullOrEmpty(A)) { return string.Empty; }

        string output = string.Empty;
        char[] vowels = new char[] {'a','e','i','o','u'};

        for (int i = 0; i < A.Length; i++)
        {
            if (vowels.Contains(A[i])) {
                output = string.Concat(output, A[i]);
            }
        }

        return output;
    }
}
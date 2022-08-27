/* SUBARRAY SUM ZERO
 */
public static class SubarraySumZeroHashMap
{
    //Technique: Maintain a prefix sum. If prefixsum values are same then we can 
    //compute the subarraya sum zero.
    public static int Operation1(List<int> A)
    {
        Dictionary<long, int> prefixIndexMap = new Dictionary<long, int>();
        long sum = 0;

        prefixIndexMap.Add(sum, -1);
        for (int i = 0; i < A.Count; i++) {

            sum += A[i];

            if (prefixIndexMap.ContainsKey(sum)) {
                return 1;
            }

            prefixIndexMap.Add(sum, i);
        }

        return 0;
    }
}
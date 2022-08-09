/*
Given an array of integers, find two numbers such that they add up to a specific target number.

The function twoSum should return indices of the two numbers such that they add up to the target,
where index1 < index2. Please note that your returned answers (both index1 and index2 ) are not zero-based. 
Put both these numbers in order in an array and return the array from your function 
( Looking at the function signature will make things clearer ). Note that, if no pair exists, return empty list.

If multiple solutions exist, output the one where index2 is minimum. If there are multiple solutions with the minimum index2,
choose the one with minimum index1 out of them.

Input: [2, 7, 11, 15], target=9
Output: index1 = 1, index2 = 2 
 */
public static class TwoSumHashMap
{
    public static List<int> solve(List<int> A, int B)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> hashmap = new Dictionary<int, int>();

        for (int i = 0; i < A.Count; i++) {

            if (hashmap.ContainsKey(B - A[i])) {

                result.Add(hashmap[B - A[i]] + 1);
                result.Add(i+1);

                return result;
            }
            else {

                if (hashmap.ContainsKey(A[i])) {

                    hashmap[A[i]] = Math.Min(hashmap[A[i]], i);
                }
                else {
                    hashmap.Add(A[i], i);
                }
            }
        }

        return result;
    }
}
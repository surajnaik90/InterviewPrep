/* AWESOME USAGE OF HASHSET IN TWOSUM PROBLEM
 * 
 * Given an array of integers nums and an integer target, 
  return true if that they add up to target.
  You may assume that each input would have exactly one solution,
  and you may not use the same element twice.

  Input: nums = [3,2,4], target = 6
  Output: true
 */
public static class TwoSumUsingHashSet
{   
    //At each element just check what value you are looking for: it is k-ar[i]
    public static bool Operation1(List<int> nums, int k)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Count; i++) {

            if(set.Contains(k-nums[i])) {
                return true;
            }

            set.Add(nums[i]);
        }

        return false;
    }
}
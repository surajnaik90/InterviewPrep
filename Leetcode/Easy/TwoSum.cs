/*Given an array of integers nums and an integer target, 
  return indices of the two numbers such that they add up to target.
  You may assume that each input would have exactly one solution,
  and you may not use the same element twice.
  You can return the answer in any order.

  Input: nums = [3,2,4], target = 6
  Output: [1,2]

  Runtime:241 ms	Memory:42.7 MB
*/
public static class TwoSum
{
    public static int[] Operation1(int[] nums, int target)
    {
        int[] output = new int[2]; int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = 0;

            for(int j=i+1; j < nums.Length; j++)
            {
                sum = nums[i] + nums[j];

                if (sum == target)
                {
                    output[0] = i;
                    output[1] = j;

                    return output;
                }
            }
        }

        return null;
    }

    public static int[] Operation2(int[] nums, int target)
    {
        Dictionary<int, int> intermediateArray = new Dictionary<int, int>();

        int[] output = new int[2]; int sum = 0, count=0;
        bool useDict = true;


        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= target && (!(nums[i] < 0))) {
                intermediateArray.Add(i, nums[i]);
            }
            if (nums[i] < 0) { useDict = false;
                break;
            }
        }

        if(useDict) {  
            count = intermediateArray.Values.Count; 
        }
        else { 
            count = nums.Length;
        }

        for (int i = 0; i < count; i++)
        {
            sum = 0;

            for (int j = i + 1; j < count; j++)
            {
                if(useDict) { 
                    sum = intermediateArray.ElementAt(i).Value + intermediateArray.ElementAt(j).Value;
                }
                else { 
                    sum = nums[i] + nums[j]; 
                }

                if (sum == target && useDict == true) {
                    
                    output[0] = intermediateArray.ElementAt(i).Key;
                    output[1] = intermediateArray.ElementAt(j).Key;

                    return output;
                }
                else if(sum == target && useDict == false) {

                    output[0] = i;
                    output[1] = j;

                    return output;
                }
                else { }
            }
        }

        return null;
    }

    public static int[] Operation3(int[] nums, int target)
    {
        Dictionary<int, int> intermediateArray = new Dictionary<int, int>();
        List<int> intermediateList = new List<int>();

        int[] output = new int[2]; int sum = 0, count = 0;
        intermediateList = nums.ToList(); intermediateList.Sort();


        for (int i = 0; i < nums.Length; i++)
        {
            intermediateArray.Add(i, nums[i]);
        }
        

        for (int i = 0; i < count; i++)
        {
            sum = 0;

            for (int j = i + 1; j < count; j++)
            {
                sum = nums[i] + nums[j];

                if (sum == target)
                {
                    output[0] = intermediateArray.ElementAt(i).Key;
                    output[1] = intermediateArray.ElementAt(j).Key;

                    return output;
                }
                else if (sum == target)
                {
                    output[0] = i;
                    output[1] = j;

                    return output;
                }
                else { }
            }
        }

        return null;
    }

}
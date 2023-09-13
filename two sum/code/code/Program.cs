using System.Reflection.Metadata.Ecma335;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            if (target >= 0)
            {
                int first = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int second = first - nums[j];
                    if (second == 0)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            else if (target < 0)
            {
                int first = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int second = first - nums[j];
                    if (second == 0)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
        }
        return result;
    }
}
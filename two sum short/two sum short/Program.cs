int[] nums = new int[5] { 2, 7, 11, 15, 12 };
int target = 9;
Solution sol = new Solution();
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] arr = new int[2];
        for(int i = 0; i < nums.Length - 1; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j)
                {
                    arr[0] = i;
                    arr[1] = j;
                }
            }
        }
        return arr;
    }
}
int[] nums = new int[10] {0, 1, 2, 3, 4, 5, 6, 7, 7, 8};
int val = 7;
Solution sol = new Solution();
Console.WriteLine(sol.RemoveElement(nums, val));
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (val != nums[i])
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}
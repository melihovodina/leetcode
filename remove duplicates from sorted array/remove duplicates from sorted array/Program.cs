int[] nums = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
Solution sol = new Solution();
Console.WriteLine(sol.RemoveDuplicates(nums));
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int temp = int.MinValue;
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (temp != nums[i])
            {
                nums[k] = nums[i];
                k++;
            }
            temp = nums[i];
        }
        return k;
    }
}
int[] nums = new int[4] { 1, 3, 5, 6 };
int target = 5;
Solution sol = new Solution();
Console.WriteLine(sol.SearchInsert(nums, target));
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int index = Array.BinarySearch(nums, target);
        return index >= 0 ? index : ~index;
    }
}
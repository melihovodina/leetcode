Solution sol = new Solution();
Console.WriteLine(sol.IsPalindrome(121));
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x >= 0)
        {
            int n = x;
            int revn = 0;
            while (n != 0)
            {
                int num = n % 10;
                revn = revn * 10 + num;
                n /= 10;
            }
            if (revn == x)
                return true;
            else return false;
        }
        else
            return false;
    }
}
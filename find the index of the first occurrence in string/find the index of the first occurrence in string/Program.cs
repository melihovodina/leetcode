string haystack = "sadbutsad";
string needle = "g";
Solution sol = new Solution();
Console.WriteLine(sol.StrStr(haystack, needle));
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
}

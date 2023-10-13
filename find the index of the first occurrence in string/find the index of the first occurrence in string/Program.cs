string haystack = "sadbutsad";
string needle = "g";
Solution sol = new Solution();
Console.WriteLine(sol.StrStr(haystack, needle));
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int k = 0;
        //if (needle.All(c => haystack.Contains(c)))
            k = haystack.IndexOf(needle);
        return k;
    }
}

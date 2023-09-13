public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> roman = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int total = 0;
        int current, previous = 0;

        char[] chars = s.ToCharArray();

        for (int i = chars.Length - 1; i >= 0; i--)
        {
            current = roman[chars[i]];

            if (current >= previous)
            {
                total += current;
            }
            else
            {
                total -= current;
            }

            previous = current;
        }

        return total;
    }
}
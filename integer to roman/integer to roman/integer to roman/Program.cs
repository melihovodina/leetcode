using System.Text;

public class Solution
{
    public string IntToRoman(int num)
    {
        Dictionary<int, string> nums = new Dictionary<int, string>() 
        {
            {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
            {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
            {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
        };
        StringBuilder roman = new StringBuilder();
        foreach (var item in nums)
        {
            while (num >= item.Key)
            {
                    roman.Append(item.Value);
                    num -= item.Key;
            }
        }
        return roman.ToString();
    }
}
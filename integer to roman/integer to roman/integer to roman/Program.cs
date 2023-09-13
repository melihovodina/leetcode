public class Solution
{
    public string IntToRoman(int num)
    {
        string total = "";
        int tries = num;
        for (int i = 0; num != 0; i++)
        {
            if (num >= 1000)
            {
                num -= 1000;
                total += "M";
            }
            else if (num >= 900)
            {
                num -= 900;
                total += "CM";
            }
            else if (num >= 500)
            {
                num -= 500;
                total += "D";
            }
            else if (num >= 400)
            {
                num -= 400;
                total += "CD";
            }
            else if (num >= 100)
            {
                num -= 100;
                total += "C";
            }
            else if (num >= 90)
            {
                num -= 90;
                total += "XC";
            }
            else if (num >= 50)
            {
                num -= 50;
                total += "L";
            }
            else if (num >= 40)
            {
                num -= 40;
                total += "XL";
            }
            else if (num >= 10)
            {
                num -= 10;
                total += "X";
            }
            else if (num >= 9)
            {
                num -= 9;
                total += "IX";
            }
            else if (num >= 5)
            {
                num -= 5;
                total += "V";
            }
            else if (num >= 4)
            {
                num -= 4;
                total += "IV";
            }
            else if (num >= 1)
            {
                num -= 1;
                total += "I";
            }
        }
        return total;
    }
}